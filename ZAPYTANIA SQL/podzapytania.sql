SELECT *
FROM Naprawy
WHERE SerwisId = (SELECT Id FROM Serwisy WHERE Nazwa = 'NazwaSerwisu')
  AND DataNaprawy BETWEEN '2024-01-01' AND '2024-12-31';

SELECT Klienci.*
FROM Klienci
WHERE Id IN (SELECT KlientId FROM Serwisy GROUP BY KlientId HAVING COUNT(*) > 1);