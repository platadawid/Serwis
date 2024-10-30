CREATE FUNCTION SredniKosztNaprawy(serwisId INT) RETURNS REAL
BEGIN
    DECLARE srednia REAL;
    SELECT AVG(CAST(Koszt AS REAL)) INTO srednia
    FROM Naprawy
    WHERE SerwisId = serwisId;
    RETURN srednia;
END;