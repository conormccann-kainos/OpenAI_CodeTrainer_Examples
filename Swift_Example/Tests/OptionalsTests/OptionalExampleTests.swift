
import XCTest
@testable import Optionals

class OptionalExampleTests: XCTestCase {
    func testCarYear() {
        let car = Car(make: "Toyota", model: "Camry", year: nil)
        XCTAssertNil(car.year)
        
        let year = car.getYear()
        XCTAssertEqual(year, 2021)
    }
}
