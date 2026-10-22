# GitHub Copilot Instructions for Dead Cryptosleep (Continued)

## Mod Overview and Purpose

**Dead Cryptosleep (Continued)** is an updated version of the mod originally created by JohnnyNova. The primary purpose of this mod is to enhance the functionality of cryptosleep caskets by allowing them to store corpses, preventing the rotting process within these caskets. This update aims to improve the management of dead bodies in RimWorld, particularly in scenarios where players want to preserve corpses for later use or disposal.

## Key Features and Systems

- **Ancient Cryptocasket Storage**: Players can now use ancient cryptocaskets as valid storage options for corpses, effectively halting the decomposition process.

- **Hauling Mechanism**: A new designation tool allows players to easily haul corpses to cryptosleep caskets, integrating with existing game mechanics for seamless usability.

- **Localization Support**: The mod is currently available in English, with an open invitation for contributions to support additional languages. Contributors are welcome to submit translations via pull requests.

## Coding Patterns and Conventions

- **C# Development**: The mod's codebase consists of several C# files, each handling different aspects of the mod's functionality. Common C# patterns such as class-based architecture and method overloading are evident.

- **Harmony Patches**: The mod uses Harmony (brrainz.harmony) for runtime method patching, enabling modifications to the game without altering base game files.

- **Naming Conventions**: Follows typical C# conventions for naming, using PascalCase for types and methods.

## XML Integration

- **Definitions (Defs)**: Utilizes XML files for defining new game concepts such as `DesignationDef`, `JobDef`, and `WorkGiverDef`. These definitions allow seamless integration with RimWorld's modding systems.

- **Patches**: XML files are also used for patching existing game elements, such as adding new designators to the game interface.

## Harmony Patching

- **Reverse Designation Database Initialization**: Enhances the base game's designation options by using Harmony to patch the initializers. This allows the new hauling designator to be added without directly modifying the game's core code.

- **Method Postfixing**: Ensures additional methods or modifications are applied after existing game methods are executed, maintaining the game's integrity and reducing the risk of conflicts with other mods.

## Suggestions for Copilot

When working with GitHub Copilot on this project, consider the following suggestions:

- **Automate Repetitive Code**: Use Copilot to generate boilerplate code for XML file parsing and C# class structures. This can speed up the development of new features or bug fixes.

- **Assist with Harmony Patching**: Allow Copilot to propose Harmony patch attributes and methods, accelerating the process of identifying where and how to apply patches.

- **Localization Handling**: Utilize Copilot to assist in generating templates for additional language support, ensuring new translations are properly structured.

- **Error Handling**: Have Copilot suggest ways to implement robust error handling, particularly when interacting with game data, to improve mod stability.

- **Testing Suggestions**: Leverage Copilot's capabilities to suggest automated testing strategies, ensuring that new features do not introduce regressions.

By keeping these guidelines in mind, you can effectively harness GitHub Copilot to enhance development productivity and maintain the quality of the Dead Cryptosleep (Continued) mod.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

