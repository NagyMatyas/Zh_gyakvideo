</br></br>
## A feladat megoldása közben vegye figyelembe a tanult OOP alapelveket: egységbezárás, láthatóság (ős és leszármazott között is), polimorfizmus stb.! 
----
##### Készítsen egy ***IKorhatáros*** nevű interfészt, ami az alábbiakat írja elő: 
- ***Korhatár*** nevű, egész számot visszaadó, csak olvasható tulajdonságot 
- ***Büntetés(életkor : szám)*** nevű, egész számot visszaadó metódust
----
##### Készítsen egy ***Film*** nevű osztályt az alábbiak szerint: 
- Kívülről csak olvasható módon tárolja a film címét és árát 
- Csak egy konstruktora legyen, ami beállítja ezeket az értékeket 
- Rendelkezzen egy ***Értékel(érték : szám)*** metódussal,
    + ami egy tömbben eltárolja a paraméterként kapott számot (1 és 5 közötti egész szám) 
    + Egy ***Film*** objektum maximum 10 értékelést tárolhat,
    + ha ennél több érkezik, akkor dobjon egy saját ***ÚjÉrtékelésHiba*** kivételt,
      + amely tartalmaz egy referenciát a kivételt dobó ***Film*** objektumra,
      + illetve ki lehessen belőle olvasni az elmenteni nem sikerült értéket
- Legyen egy csak olvasható ***Átlag*** tulajdonsága, ami visszaadja a értékelések átlagát 
    + Amennyiben még nincs értékelés, akkor dobjon egy ***ÁtlagSzámításHiba*** kivételt,
    + ami tartalmaz egy referenciát a kivételt dobó ***Film*** objektumra 
    + A két kivételnek célszerűen legyen egy közös őse a közös mezők és tulajdonságok kezelésére 
----
##### Készítsen egy ***AkcióFilm*** nevű osztályt, amely a ***Film*** leszármazottja: 
- Egészítse ki egy mezővel, ami tárolja a film alsó korhatárát 
- Ez a mező a konstruktorban legyen beállítható 
- Módosítsa úgy az ***Értékel*** metódust,
  + hogy az 5-ös értékeléseket hagyja figyelmen kívül, csak az annál kisebbeket mentse el a ***Film***ével azonos módon 
- Valósítsa meg az ***IKorhatáros*** interfészt az alábbiak szerint: 
    + A visszaadott korhatár legyen: a korhatár mező értéke 
    + A büntetés mértéke legyen: ***(életkor paraméter – korhatár) * ár***
----
##### Készítsen egy ***Puzzle*** osztályt az alábbiak szerint: 
- Konstruktorban beállítható és kívülről csak olvasható módon tárolja a darabszámot 
- Valósítsa meg az ***IKorhatáros*** interfészt az alábbiak szerint: 
    + A visszaadott korhatár legyen: ***darabszám / 500***
    + A büntetés mértéke legyen: ***(életkor paraméter – korhatár) * 1000***
----
##### Készítse el az alábbi főprogramot: 
- Hozzon létre egy tömböt, és töltse fel néhány fixen megadott ***Film*** és ***AkcióFilm*** objektummal 
- Keresse meg a legrosszabb filmet és írja ki annak adatait a képernyőre (*kezelje az esetlegesen 
felmerülő kivételeket*)
- Hozzon létre egy tömböt, amiben ***IKorhatáros*** interfészt megvalósító elemeket tárolhat. 
Másolja ide a filmekből az ***AkcióFilmek***et, és rakjon bele fixen megadott ***Puzzle*** objektumokat 
- Ez alapján számolja meg, hogy egy megadott életkor esetén hány ***Film***et és ***Puzzle***t lehet 
büntetlenül megvásárolni, illetve mennyi lenne az összes büntetés, ha mindent megvennénk 
----
</br></br></br></br></br></br>