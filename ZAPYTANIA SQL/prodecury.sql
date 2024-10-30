CREATE PROCEDURE DodajNaprawe(IN opis TEXT, IN koszt TEXT, IN dataNaprawy TEXT, IN serwisId INT)
BEGIN
    INSERT INTO Naprawy (Opis, Koszt, DataNaprawy, SerwisId)
    VALUES (opis, koszt, dataNaprawy, serwisId);
END;

CREATE PROCEDURE AktualizujKosztNaprawy(IN naprawaId INT, IN nowyKoszt TEXT)
BEGIN
    UPDATE Naprawy
    SET Koszt = nowyKoszt
    WHERE Id = naprawaId;
END;