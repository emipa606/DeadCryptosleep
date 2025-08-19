# Copilot Instructions for Dead Cryptosleep (Continued) Mod Development

Welcome to the Dead Cryptosleep (Continued) mod development! This document aims to provide Copilot with instructions for assisting in the project's development, ensuring that contributors can provide meaningful enhancements and maintain the mod's standards.

## Mod Overview and Purpose
**Dead Cryptosleep (Continued)** is an update of JohnnyNova's original mod, "Frontier Developments Dead Cryptosleep," for RimWorld. The primary purpose of this mod is to enable colonists to haul corpses to cryptosleep caskets. This is particularly helpful for players who want to preserve the bodies of colonists or enemies for future purposes in the game.

## Key Features and Systems
- **Hauling Corpses to Cryptosleep Caskets:** This mod introduces a new work designation that allows colonists to transport deceased bodies into cryptosleep caskets, preventing decay.
- **Language Support:** Currently supports English and is open to localizations.
- **Contribution Model:** Contributions via pull requests are encouraged, and contributors will be credited while the mod ultimately retains ownership of the merged submissions for consistency and potential future licensing changes.

## Coding Patterns and Conventions
- **C# Naming Conventions:** Use PascalCase for class and method names. Use camelCase for local variables and parameters.
- **File Organization:** Classes are separated into individual files, named after the primary class they contain (e.g., `Designator_HaulCryptosleep.cs`).
- **Comments and Documentation:** Methods and classes should be well-documented with XML comments to describe their purpose and functionality. Maintain consistency in documentation to improve clarity and maintainability.

## XML Integration
- **Defs and Configurations:** XML files define new designators and job drivers linked with C# classes. Ensure XML files are correctly referenced within the mod's `About` folder and appropriately loaded by the game.
- **Localization Files:** Place language-specific XML files in the appropriate folder structure to allow easy translation and integration (e.g., `Languages/English/Keyed/`).

## Harmony Patching
- **Method Patching:** Utilize Harmony for prefixing or postfixing methods where necessary to extend game functionality.
- **Performance Considerations:** Ensure that patches are efficient and do not introduce performance bottlenecks. Test patches thoroughly to avoid unintended game behavior.

## Suggestions for Copilot
- **Suggest Boilerplate Code:** Provide suggestions for common RimWorld modding boilerplate code, such as class templates for new `JobDriver` or `WorkGiver` implementations.
- **Autocompletion for Class Instantiation:** Offer autocompletion for creating instances of classes used in job designation and hauling logic.
- **Code Comments:** Generate comments for methods and classes that explain their functionality within the context of the mod.
- **Syntax and Error Checking:** Offer suggestions and corrections for C# syntax errors, ensuring that code compiles without issues in the RimWorld environment.

By following these guidelines, contributors and Copilot can work together to enhance the Dead Cryptosleep (Continued) mod effectively and maintain its quality. We welcome all constructive contributions and hope this document serves as a helpful guide in the development process.
