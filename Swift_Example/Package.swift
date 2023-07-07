
// swift-tools-version:5.5

import PackageDescription

let package = Package(
    name: "Optionals",
    platforms: [.iOS(.v15), .macOS(.v12), .watchOS(.v8), .tvOS(.v15)],
    products: [
        .library(
            name: "Optionals",
            targets: ["Optionals"]),
    ],
    dependencies: [],
    targets: [
        .target(
            name: "Optionals",
            dependencies: []),
        .testTarget(
            name: "OptionalsTests",
            dependencies: ["Optionals"]),
    ]
)
