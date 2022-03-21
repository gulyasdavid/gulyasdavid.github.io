import random as r
hiba=True
szam1=0
szam2=0
szam3=0
szam4=0
szam5=0
while (hiba):
    print("Adj meg 5 számot 1 és 90 között!")
    try:
        if (szam1 == szam2 or szam1 == szam3 or szam1 == szam4 or szam1 == szam5 or szam2 == szam3 or szam2 == szam4 or szam2 == szam5 or szam3 == szam4 or szam3 == szam5 or szam4 == szam5):
            szam1=int(input())
            szam2=int(input())
            szam3=int(input())
            szam4=int(input())
            szam5=int(input())
            hiba = False
        else:
            print("Csak 1 és 90 közötti számot fogadok el!!!")
    except:
        print("Térj már észhez paraszt!!!")
print("Ezeket a számokat adtad meg: ",szam1,szam2,szam3,szam4,szam5)
input()

hiba=True
while (hiba):
    print("Legenerálok 5 véletlen számot 1 és 90 között!")
    try:
        if (rand1 == rand2 or rand1 == rand3 or rand1 == rand4 or rand1 == rand5 or rand2 == rand3 or rand2 == rand4 or rand2 == rand5 or rand3 == rand4 or rand3 == rand5 or rand4 == rand5):
            rand1=r.randrange(1,90)
            rand2=r.randrange(1,90)
            rand3=r.randrange(1,90)
            rand4=r.randrange(1,90)
            rand5=r.randrange(1,90)
            hiba=False
        else:
            rand1=r.randrange(1,90)
            rand2=r.randrange(1,90)
            rand3=r.randrange(1,90)
            rand4=r.randrange(1,90)
            rand5=r.randrange(1,90)
            hiba=True
    except:
        print("Térj már észhez hülye gép!!!")

print("Ezeket a számokat sorsolta ki a gép: ",rand1,rand2,rand3,rand4,rand5)
input()

osszeg=0
for i in range(0,25):
    if (szam1==rand1 or szam1==rand2 or szam1==rand3 or szam1==rand4 or szam1==rand5 or szam2==rand1 or szam2==rand2 or szam2==rand3 or szam2==rand4 or szam2==rand5 or szam3==rand1 or szam3==rand2 or szam3==rand3 or szam3==rand4 or szam3==rand5 or szam4==rand1 or szam4==rand2 or szam4==rand3 or szam4==rand4 or szam4==rand5 or szam5==rand1 or szam5==rand2 or szam5==rand3 or szam5==rand4 or szam5==rand5):
        osszeg+=1
    else:
        pass

print("Ennyi szám azonos a két számsorozatban: ",osszeg)
input("Nyomj meg egy gombot a befejezéshez!")