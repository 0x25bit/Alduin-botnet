class Country {
    constructor(country, piece) {
        this.Country = country;
        this.Piece = piece;
    }
    get getCountry() {
        return this.Country;
    }
    get getPiece() {
        return this.Piece;
    }
    set setPiece(number) {
        this.Piece = number;
    }
    set setCountry(number) {
        this.Piece = number;
    }
}
