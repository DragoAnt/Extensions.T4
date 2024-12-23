# Extensions.T4

## Overview

`Extensions.T4` is a library designed to enhance the capabilities of T4 (Text Template Transformation Toolkit) templates. It provides utilities and extensions that simplify the process of generating code using T4 templates.

## Purpose

The main purpose of this package is to facilitate the generation of data-driven code using T4 templates. It allows developers to define templates that can dynamically generate code based on input data, making it easier to maintain and scale codebases.

## Features

- **Data-Driven Code Generation**: Use input data to drive the generation of code, reducing manual coding and potential errors.
- **Customizable Templates**: Create templates that can be reused across different projects or modules.
- **Integration with Existing Projects**: Easily integrate T4 templates into existing projects to automate repetitive coding tasks.

## Example Usage

Below is an example of how to use a T4 template with the `Extensions.T4` package. This example demonstrates generating a static class with a property that returns an array of integers.

### T4 Template: `TestTemplate.tt`
```csharp
<#@ template language="C#" linePragmas="false" inherits="BaseTransformation<TemplateTestData>" visibility="internal" #>
<#@ import namespace="DragoAnt.Extensions.T4" #>
namespace <#= Data.Namespace #>;
internal static class TestClass
{
public static int[] Property => [<#= string.Join(", ", Data.Numbers) #>];
}
```


### Explanation

- **Template Inheritance**: The template inherits from `BaseTransformation<TemplateTestData>`, allowing it to access the data model `TemplateTestData`.
- **Namespace Generation**: The namespace is dynamically generated using `Data.Namespace`.
- **Property Generation**: The `Property` is an array of integers, generated from `Data.Numbers`.

### Project Properties for `.tt` File

To ensure the `.tt` file works correctly, make sure the following properties are set in your project file (`.csproj`):

- **Generator**: Set to `TextTemplatingFilePreprocessor`.
- **LastGenOutput**: Specifies the output file name, e.g., `TestTemplate.cs`.

## Example of `TemplateTestData`

Here's an example of what the `TemplateTestData` class might look like:

```csharp
public class TemplateTestData
{
    public string Namespace { get; set; }
    public List<int> Numbers { get; set; }
}
```

## How to Use `TestTemplate`

Here's a step-by-step example similar to the one in `TemplateTests.cs`:

1. **Prepare Data**: Create an instance of `TemplateTestData` with the desired namespace and numbers.

    ```csharp
    var data = new TemplateTestData
    {
        Namespace = "MyNamespace",
        Numbers = new List<int> { 1, 2, 3 }
    };
    ```

2. **Run the Template**: Use the T4 template engine to process `TestTemplate.tt` with your data.

    ```csharp
    var template = new TestTemplate
    {
        Data = data
    };
    var result = template.TransformText();
    ```

3. **Integrate Generated Code**: The generated code will be available in your project, ready for use.

## Getting Started

To start using `Extensions.T4`, include it in your project and create T4 templates as shown in the example. Customize the templates to fit your specific needs and data structures.

## License

This project is licensed under the terms of the MIT license. See the [LICENSE](LICENSE) file for details.
