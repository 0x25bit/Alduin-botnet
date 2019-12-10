using NHibernate;
using System;
using Alduin.Shared.Interfaces.UnitOfWork;

namespace Alduin.Logic.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ISession _session;

        private ITransaction transaction;

        public bool IsManagedTransaction { get; private set; }

        public UnitOfWork(ISession session)
        {
            _session = session;
            transaction = null;

            IsManagedTransaction = false;
        }

        public void BeginTransaction()
        {
            if (transaction != null && transaction.IsActive)
                throw new InvalidOperationException("There is an open transaction already!");

            transaction = _session.BeginTransaction();
            IsManagedTransaction = true;
        }

        public void Commit()
        {
            // TODO localization
            if (transaction == null || !transaction.IsActive)
                throw new InvalidOperationException("There is no transaction to commit!");

            transaction.Commit();

            IsManagedTransaction = false;
        }

        public void InTransaction(Action action)
        {
            if (transaction != null)
                throw new InvalidOperationException("There is an open transaction already!");

            using (var trans = _session.BeginTransaction())
            {
                action();
                trans.Commit();
            }
        }

        public void Rollback()
        {
            // TODO localization
            if (transaction == null || !transaction.IsActive)
                throw new InvalidOperationException("There is no transaction to roll back!");

            transaction.Rollback();
            transaction.Dispose();
            transaction = null;

            IsManagedTransaction = false;

            _session.Clear();
        }

        public void Dispose()
        {
            if (transaction != null && transaction.IsActive)
                Rollback();
        }
    }
}
