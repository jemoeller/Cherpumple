# Domain
Contains enterprise-wide logic and types.

## Overview
Entities, Value Objects, Enumerations, Logic, Exceptions

## Notes
Dont clutter Domain model with data annotations. EF core doesnt use it for validation, only mapping.

Use value objects where appropriate

automatically track changes with things such as auditable entity.

Create custom domain exceptions.

Always initiate collections and use private setters.