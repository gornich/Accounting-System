# Accounting-System

## Conflict Resolution Log

### 2026-05-03: Merge conflict in `Program.cs`

**Branches involved:**
- `develop` (target)
- `feature/status-manager` (source)

**Conflict cause:**
Both branches modified line 2 of `Program.cs` differently.

**Resolution:**
- Chose DEVELOP version as primary (`add_expense(1001);`)
- Added FEATURE version as a comment for reference
- Verified both implementations are functionally compatible

**Commands used:**
```bash
git checkout develop
git merge feature/status-manager
# Manual resolution in Program.cs
git add Program.cs
git commit -m "Resolved merge conflict..."
Outcome:
All tests pass. Both features are now integrated successfully.

Программный модуль для ведения бухгалтерского и налогового учета на предприятиях малого и среднего бизнеса. Реализует принцип двойной записи, автоматическое формирование проводок по шаблонам, построение оборотно-сальдовой ведомости, бухгалтерского баланса и налоговых деклараций (НДС, прибыль, УСН) с выгрузкой в Excel, PDF и XML.

Стек: Java 17, Spring Boot, PostgreSQL, Maven.

Для сборки выполните `./mvnw clean package`
для запуска — `java -jar target/accounting-system-1.0.0.jar`.
Приложение будет доступно на `http://localhost:8080`.