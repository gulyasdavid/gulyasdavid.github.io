-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 11. feladat:


-- 13. feladat:


-- 14. feladat:


-- 15. feladat:

 
-- 16. feladat:

  
-- 17. feladat:
SELECT szalloda.nev AS "Szálloda neve",AVG(utak.ar) AS "Átlagár/fő",besorolas AS "Csillagok száma"
FROM szalloda INNER JOIN utak ON szalloda.helyseg_az INNER JOIN helyseg.az=szalloda.helyseg_az
WHERE helyseg.orszag="Egyiptom" AND utak.idotartam = 8
GROUP BY szalloda.nev,szalloda.besorolas
ORDER BY "Átlagár/fő" DESC LIMIT 1
