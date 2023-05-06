# Adapter Pattern
The adapter pattern is a structural design pattern that allows incompatible interfaces to work together. In other words, 
it allows objects with incompatible interfaces to collaborate by wrapping its own interface around that of an already 
existing class. The adapter pattern is used when the desired class does not meet the interface requirements of another class.

In this specific implementation, we have a `Person` class that can be converted to XML or CSV formats. However, we need 
to convert these formats to JSON. To accomplish this, we can use the adapter pattern by creating an `IJsonConverter` 
interface and two concrete implementations, `XmlToJsonConverter` and `CsvToJsonConverter`.

## Problem
The `Person` class can be serialized to XML or CSV formats, but we need to be able to serialize it to JSON format as well. 
We cannot directly serialize the Person class to JSON, as it does not implement the required interface for JSON serialization.
We need to find a way to convert the XML and CSV formats to JSON format, which requires a different interface.

## Solution
To solve this problem, we can use the adapter pattern to create two concrete implementations of the `IJsonConverter` interface, 
`XmlToJsonConverter` and `CsvToJsonConverter`. These adapters will take in an XML or CSV string and convert it to a JSON string.

The `XmlToJsonConverter` adapter will parse the XML string and create a JSON string with the same data. The `CsvToJsonConverter` 
adapter will parse the CSV string and create a JSON string with the same data.

By creating these adapters, we can now use the `Person` class to serialize to JSON by first converting it to either XML or 
CSV format, and then using the respective adapter to convert it to JSON. This allows us to keep the Person class implementation 
unchanged, while still being able to serialize it to JSON format.