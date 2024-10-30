# Dokumentacja projektu C# MVC

## Opis instalacji i wymagań systemowych

Aby zainstalować aplikację, upewnij się, że masz zainstalowane następujące oprogramowanie:

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) lub nowsza wersja.
- [SQLite](https://www.sqlite.org/download.html) jako system zarządzania bazą danych.
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (zalecana wersja) lub inny edytor obsługujący C#.

### Wymagania systemowe

- System operacyjny: Windows 10/11, Linux (Ubuntu), lub macOS.
- Minimum 4 GB RAM.
- Minimum 2 GHz procesor.

## Szczegóły dotyczące konfiguracji

### Łańcuch połączenia z bazą danych

Aby skonfigurować połączenie z bazą danych, zaktualizuj plik `appsettings.json`, dodając odpowiedni łańcuch połączenia.

Dla SQLite:

```json
"ConnectionStrings": {
    "Database":"Data Source=dbdb.db"
}
```

## Opis działania aplikacji z perspektywy użytkownika końcowego

Aplikacja jest zaprojektowana z myślą o prostocie i użyteczności. Użytkownicy mogą:

1. **Przeglądać dostępne zasoby** – Użytkownicy mogą przeglądać listę dostępnych zasobów, takich jak serwisy, naprawy etc.

2. **Dodawać nowe zasoby** – Użytkownicy mają możliwość dodawania nowych zasobów do systemu.

3. **Edytować istniejące zasoby** – Użytkownicy mogą edytować informacje o zasobach, które stworzyli.

4. **Usuwać zasoby** – Użytkownicy mogą usunąć zasoby, które już nie są potrzebne.
