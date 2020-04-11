# Design

## Goal

The goal of this exercise is to teach the student the basics of tuples and common conventions in elixir to return multiple values.

This is done through implmentation of a kitchen calculator.

## Learning objectives

- Know what a tuple is
- Know how to write a tuple literal
- Know how to return a tuple from a function
- Know how to extract an element from a tuple using `elem/2`

## Out of scope

- pattern matching
  - including parameter deconstruction techniques

## Prerequisites

The exercise's prerequisites are:

- `basics`: needs to be able to define named functions, define and return integers, return values from functions
- `atoms`: needs to be able to define and use atoms for return values

## Concepts this unlocks are:

- `tuples` know of the existence of the `tuple` data type, how to define tuple literals, extract values from a tuple using `elem/2`
- `floating-point-numbers` know of the existence of the floating point number type, know that it is double precision float encoding, how to convert it to an integer type

## Representer

This exercise does not require any specific representation logic to be added to the [representer][representer].

## Analyzer

This exercise could benefit from the following rules added to the the [analyzer][analyzer]:

- Verify common conversion functions aren't used from the standard library if they exist.

[analyzer]: https://github.com/exercism/elixir-analyzer
[representer]: https://github.com/exercism/elixir-representer