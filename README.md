# Aplikacja "Moja walizka"

Celem działania jest sporządzenie listy rzeczy potrzebnych na wyjazd.\
Powinna umożliwić wybór rodzaju wyjazdu (służbowy/wakacyjny itd.) ze zbioru list predefiniowanych.\
Przedmiot z listy predefiniowanej powinien być możliwy do usunięcia, tak aby pozostały na niej tylko potrzebne rzeczy.\
Do listy predefiniowanej można również dodawać nowe przedmioty.\
Końcowym efektem powinno być wygenerowanie dokumentu PDF z gotową do wydruku listą rzeczy.\
Listy przedmiotów zapisywane są w bazie danych Sql Server Compact.

## Funkcje programu

- Dodawanie/edytowanie/usuwanie kategorii przedmiotów
- Dodawanie/edytowanie/usuwanie przedmiotów
- Dodawanie/edytowanie/usuwanie list przedmiotów
- Przypisywanie przedmiotów do kategorii
- Przypisywanie przedmiotów do list
- Zapisywanie list przedmiotów jako listy predefiniowane
- Zapisywanie list przedmiotów jako historie podróży
- Eksport list przedmiotów do .pdf (TODO)

## Użyte technologie
- .NET Framework
- C#
- WPF
- XAML
- Entity Framework 6
- SQL Server Compact

## Skorzystaliśmy również z:
- Material Design In XAML Toolkit (http://materialdesigninxaml.net)
- GhostDoc (https://submain.com/ghostdoc)

## Dodatkowe informacje

- Aplikacja zainstalowana w domyślnej lokalizacj (C:\Program Files(x86)\) do uruchomienia wymaga uprawnień administratora.
- Aplikacja zainstalowana w katalogu użytkownika nie wymaga dodatkowych uprawnień.
