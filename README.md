# Projekt zaliczeniowy SoftwareStore

Projekt zaliczeniowy z przedmiotu Programowanie w środowisku ASP.NET. Aplikacja jest sklepem internetowym, który oferuje sprzedaż specjalistycznego oprogramowania komputerowego, gier oraz voucherów. 

## Instalacja

1. Należy sklonować repozytorium przy użyciu linku: [https://github.com/Bartek4175/SoftwareStore](https://github.com/Bartek4175/SoftwareStore).
2. Po poprawnym sklonowaniu należy edytować dane do bazy danych. Ustawienia dostępne są w folderze SoftwareStore w pliku appsettings.json. Edytować należy nazwę serwera bazy danych, która zlokalizowana jest w 11 linii:
    ```json
    "ConnectionString": "DATA SOURCE=DESKTOP-LVMKQE4;Integrated Security=true;DATABASE=SoftwareStore;TrustServerCertificate=True;"
    ```
    gdzie "DESKTOP-LVMKQE4" odpowiada nazwie serwera, którą należy edytować.

3. Następnie należy wykonać migrację. W terminalu (Prawy przycisk myszy na projekt -> Otwórz w terminalu) należy wpisać komendy:
    ```json
    dotnet ef migrations add NazwaMigracji
    dotnet ef database update
    ```

4. Po poprawnej edycji i migracji wystarczy włączyć debugowanie programu.

## Użytkownicy
Program domyślnie tworzy użytkownika z uprawnieniami administratora oraz standardowego użytkownika.\
Dane do konta z dostępem administratora:
 - login: **admin@SoftwareStore.com**
 - hasło: **Coding@1234?**

Dane do konta standardowego:
 - login: **user@SoftwareStore.com**
 - hasło: **Coding@1234?**
