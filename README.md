# Interface import bug reproduction

This repo is to demonstrate and reproduce a bug introduced in Fable 4.1.3 and still present in 4.2.2.

## Description

When an interface is defined in one file (see `Source.fs`) and the interface is used as a generic interface type constraint for a discriminated union in another file (see `Program.fs`), the generated JavaScript file containing the DU attempts to import the interface even though no code is generated for the interface.

## System information

* Operation system: macOS 14.0
* .NET SDK: 7.0.401 and 8.0.100-rc.2.23502.2
* Fable compiler: 4.1.3 and 4.2.2

## Reproduction steps

1. Clone the repo
2. `dotnet tool restore`
3. `dotnet restore`
4. `dotnet fable`
5. Open the generated file `Program.fs.js`
6. Note `import { IErrorInterface } from "./Source.fs.js";`. This is the line causing the error.

## Additional information

This bug is not present in Fable 4.1.2.

In `Program.fs`, you can comment out the type `ErrorUnion` and uncomment the other types above it. If you run `dotnet fable` again, the bug is not present in the generated file.
