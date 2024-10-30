CREATE TRIGGER AktualizujTelefon
AFTER INSERT ON Klienci
FOR EACH ROW
BEGIN
    IF NEW.Telefon IS NULL THEN
        UPDATE Klienci
        SET Telefon = 'Nieznany'
        WHERE Id = NEW.Id;
    END IF;
END;