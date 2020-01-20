# Automation-Aspect-code
Automating .NET Core Services with PostSharp and Aspect-Oriented Code


The goal is to create a small application which can:
- Host common services and load native classes based on OSVersion.
- Automatically wrap logging around the entire solution.
- Automatically thread the services for a multi-core computer.
- Validate architecture so that bugs throw exceptions in a deterministic way.

# Technical Details
It is not completely bug free. You need to have a postsharp license.

The .Net Core version is 3.1

Tutorial Link: https://medium.com/dealeron-dev/automating-net-core-services-with-postsharp-and-aspect-oriented-code-a8a51d8d84ec

# Commit Messages
Must be one of the following

- build: Changes that affect the build system or external dependencies (example scopes: webpack, npm)
- config: configuration changes only
- docs: Documentation only changes
- feat: A new feature
- fix: A bug fix
- perf: A code change that improves performance
- refactor: A code change that neither fixes a bug nor adds a feature
- style: Changes that do not affect the meaning of the code (white-space, formatting, missing semi-colons, etc)