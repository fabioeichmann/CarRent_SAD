# Big Picture

## Context

Es soll ein neues Autovermietungssystem „CarRent“ erstellt werden. Das System soll aus Server-Teilen und optional einen Web-Client bestehen.
a) Die Daten sollen mittels «Repository Pattern» in eine Datenbank gespeichert werden können.
b) Die Business Logik soll auf dem Backend laufen und REST APIs anbieten.
c) Es soll zuerst ein Monolith erstellt werden und später auf eine Micro Service Architektur überführt werden.
Optional:
d) Der Web-Client benutzt die REST API um die Funktionen auszuführen.

![System_Context](\diagrams\images\System_Context.png)

#### Anforderungen

| Nr.  | Anforderungen                                                |
| ---- | ------------------------------------------------------------ |
| 1    | Der Sachbearbeiter muss Kunden mit den Basis CRUD Operationen verwalten können |
| 2    | Der Sachbearbeiter muss Kunden mit dessen Namen oder Kundennummer im System suchen können |
| 3    | Der Sachbearbeiter muss Fahrzeuge mit den Basis CRUD Operationen verwalten können |
| 4    | Der Sachbearbeiter muss ein Fahrzeug den folgenden Typen zuordnen können Luxusklasse, Mittelklasse, Einfachklasse |
| 5    | Der Sachbearbeiter muss jeder Klasse eine Tagesgebühr hinterlegen können |
| 6    | Der Sachbearbeiter muss jede Reservation einsehen und mit CRUD Operationen verwalten können |
| 7    | Der Sachbearbeiter muss bei Reservationen sobald das Fahrzeug abgeholt wurde den Status auf "Vermietet" setzen |
| 8    | Das System muss anhand der Mietdauer eines Fahrzeuges und deren ausgewählten Klasse die Gesamtkosten berechnen |
| 9    | Ein Fahrzeug muss folgende Informationen besitzen, Marke, Typ, eindeutige Identifikation und Klasse |
| 10   | Jede Klasse besitzt eine Tagesgebühr                         |
| 11   | Ein Kunde kann ein Fahrzeug anhand der Klasse suchen         |
| 12   | Ein Kunde muss bei einer Reservation das gewünschte Start- und Enddatum angeben |
| 13   | Der Kunde erhält bei einer abgeschlossenen Reservation eine Reservationsnummer |
| 14   | Der Kunde sieht vor der Reservation die Gesamtkosten         |

#### Rollen

| Rolle          | Name           | Erwartung                                            |
| -------------- | -------------- | ---------------------------------------------------- |
| Sachbearbeiter | Person1        | System zur Verwaltung der Vermietungen               |
| Kunde          | Person2        | Einfache und schnelle Möglichkeit ein Auto zu mieten |
| Entwickler     | Fabio Eichmann | Entwicklung des Systems                              |



## Containers

Die folgenden technischen Einschränkungen müssen beim Projekt berücksichtigt werden:

- Die Anwendung muss schlussendlich als Mikroservice-Architektur entwickelt werden
- Die Anwendung muss das Repository Pattern verwenden
- Die Business Logik soll auf dem Backend laufen und REST APIs anbieten

![Container](\diagrams\images\Container.jpg)

## Component

![Component](\diagrams\images\Component.jpg)

## Domain Model

![Domain Model](\diagrams\images\Domain Model.jpg)

## 4+1 Views

### Deployment View

![Untitled Diagram](\diagrams\images\Untitled Diagram.jpg)

### Logical View

![Logical View](\diagrams\images\Logical View.jpg)

### Implementation View

![Implementation View](\diagrams\images\Implementation View.jpg)
