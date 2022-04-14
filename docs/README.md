# M318 Projektarbeit "Oev-Pad" Dokumentation von Kris Huber

## Einleitung

### Über dieses Dokument

* Autor: **Kris Huber**
* Erstelldatum: **14.04.2022**

### Über das Projekt

Wir haben 12.04.2022 mit der Projektarbeit gestartet und am 14.04.2022 war der Abgabetermin.

### Über die Software

Die mit C#, Winforms, .Net Core entwickelte Software hat die Aufgabe, als eine grafische Benutzeroberfläche für die Opendata Transport API zu dienen.

### Zweck

Diese Dokumentation ist dazu da, um die Projektarbeit in menschlicher Sprache lesbar festzuhalten. Dazu enthält die Dokumentation weitere Informationen wie: User Stories & Planung (Prio), Testfälle und Mock Ups. Diese Dokumentation würde auch, wenn dieses Projekt in der Echtwelt eingesetzt würde, Benutzern helfen, die Software mit der Installationsanleitung zu installieren.

## User Stories

| ID    | User Story                                                   | Abnahmekriterien                                             | Priorität   | Umgesetzt |
| ----- | ------------------------------------------------------------ | ------------------------------------------------------------ | ----------- | --------- |
| **1** | **Verbindungssuche**<br />Als Benutzer möchte ich mindestens die nächsten vier Verbindungen zwischen einer Start- und Endstation suchen können, um für mich eine passende Verbindung zu finden. | - Startstation in Textfeld eingeben <br />- Endstation in Textfeld eingeben<br />- Listet mindestens nächsten vier Verbindungen auf | 1           | ✅         |
| **2** | **Abfahrtstafel**<br />Als Benutzer möchte ich eine Abfahrtstafel, um alle Verbindungen einer Startstation zu sehen. | - Startstation in Textfeld eingeben<br />- Anzeigen sämtlicher ausgehender Verbindungen von dort | 1           | ✅         |
| **3** | **Stationssuche**<br />Als Benutzer möchte ich nach einer Station suchen können, um diese als Start- oder Endstation auswählen zu können. | - Anzeigen aller Stationen, die den Suchbegriff im Namen enthalten<br />- Passende Station kann als Start-/Endstation ausgewählt werden | 1           | ✅         |
| **4** | **Stationssuche Autocomplete**<br />Als Benutzer möchte ich bei der Eingabe der Stationssuche automatisch Vorschläge erhalten, um eine Station, deren Namen ich nicht genau kenne, einfacher zu finden. | - Autovervollständigung der Eingabe bei Stationssuche<br />- Fuzzy Search | 2           | ✅         |
| **5** | **Datum und Uhrzeit Filter**<br />Als Benutzer möchte ich ein Abfahrtsdatum und Uhrzeit eingeben können, um Verbindungen in der Zukunft einsehen zu können. | - Abfahrtsdatum auswählen<br />- Abfahrtszeit auswählen<br />- Entsprechende Verbindungen anzeigen | 2           | ✅         |
| **6** | **Nächste Stationen**<br />Als Benutzer möchte ich die nächsten Stationen zu meinem Standort einsehen können, um zu wissen, wo ich am besten einsteigen soll. | - Standort erfassen<br />- Alle Stationen im nahen Umkreis anzeigen<br /> | 3           | ✅         |
| **7** | **Stationenkarte**<br />Als Benutzer möchte ich eine Station auf einer Karte sehen können, um zu wissen, wo sich die Station befindet. | - Station auswählen<br />- Station auf interaktiver Karte einzeichnen | 3           | ✅         |
| **8** | **Verbindung teilen**<br />Als Benutzer möchte ich eine Verbindung per Email teilen können, um andere über eine Verbindung informieren zu können. | - Verbindung auswählen<br />- Textfeld für Empfänger-Email Adresse<br />- Textfeld für optionale Nachricht<br />- Uhrzeit, Start- und Endstation der Verbindung an Empfänger senden | 3           | ✅         |
| **9** | **Take Me Home**<br />Als Benutzer möchte ich einen "Take Me Home" Shortcut haben können, um mir die schnellste Verbindung von meinem aktuellen Standort zu meiner Heimadresse zu geben. | - Einstellung für Heimadresse<br />- Standort erfassen<br />- Nächste Startstation zum aktuellen Standort finden<br />- Nächste Endstation zu Heimadresse finden<br /> | Eigene Idee | ✅         |

## Mockups

### Abfahrtstafel

> User Story 2

![Abfahrtstafel](assets/Mockup_UserStory2.png)

### Verbindungssuche

> User Story 1

![Verbindungssuche](assets/Mockup_UserStory1.png)

## Testfälle

### Computer-Zustand Anforderungen:

- Internetverbindung
- Oev-Pad Applikation geöffnet

### Station suchen

**Anforderungen:** 1, 4

**Tab:** Station Finder

| Schritt | Aktivität                                                    | Erwartetes Resultat                                          |
| ------- | ------------------------------------------------------------ | ------------------------------------------------------------ |
| 1       |                                                              | Es werden keine Vorschläge angezeigt.                        |
| 1       | Ich gebe "luz" in die "From", "To" oder "Station" Textbox ein. | Es werden alle Haltestellen die mit Luzern anfgagen angezeigt (Luzern, Luzern Bahnhof, Luzern Kantonalbank, Luzern Pilatusplatz, Luzern,Schwanenpaltz, LuzernLuzernerhof, Luzern Allmend/Messe, Luzern Gütsch, LuzernKassernenplatz, Luzern Eichhof). |
|         |                                                              |                                                              |
|         |                                                              |                                                              |
