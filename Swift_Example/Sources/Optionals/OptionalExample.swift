
class Car {
    var make: String
    var model: String
    var year: Int?
    
    init(make: String, model: String, year: Int) {
        self.make = make
        self.model = model
        self.year = year
    }
    
    func getYear() -> Int {
        return year!
    }
}
