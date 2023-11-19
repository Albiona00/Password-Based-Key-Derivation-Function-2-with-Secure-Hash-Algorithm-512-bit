# Password-Based-Key-Derivation-Function-2-with-Secure-Hash-Algorithm-512-bit
PBKDF2-SHA512 Password-Based Key Derivation Function 2 është një metodë e përdorur për të derivuar një çelës ose një vlerë tjetër të rastësishme nga një fjalëkalim, duke përdorur algoritmin e kodimit SHA-512 dhe një protokol për ndryshimin e fjalëkalimit.
Kjo është shumë e rëndësishme për sigurinë e fjalëkalimeve, veçanërisht kur duhet ruajtur fjalëkalimi në një bazë të të dhënave ose të transmetohet në një mënyrë tjetër të paenkriptuar. Përdorimi i PBKDF2 me SHA-512 ka disa përfitime në krahasim me përdorimin e algoritmeve më të dobëta të kodimit të fjalëkalimeve.
Kur një përdorues regjistrohet ose ndryshon fjalëkalimin, PBKDF2-SHA512 përdoret për të kryer një proces i cili bën shumë iteracione të algoritmit SHA-512 duke përdorur një vektor rastësor (salt) dhe fjalëkalimin e dhënë. Ky proces siguron një çelës të fortë dhe të vështirë për tu kuptuar edhe në rastin e një sulmi me brute force. Kjo teknikë parandalon ose bën shumë të vështirë përdorimin e tabelave të koduara paraprakisht (rainbow tables) për gjetjen e fjalëkalimit origjinal.
Përdorimi i një algoritmi të fortë të kodimit (SHA-512 në këtë rast) dhe i një procesi të shumëfishtë iterativ (PBKDF2) rritë sigurinë e fjalëkalimeve dhe parandalon shumicën e sulmeve potenciale që mund të bëhen për të gjetur fjalëkalimet duke përdorur teknika të ndryshme si brute force ose përdorimin e tabelave të koduara paraprakisht.

Hyrje
Ky projekt ofron një aplikacion thjeshtë Windows Forms për hashim të sigurt të fjalëkalimeve duke përdorur algoritmin PBKDF2-SHA512. Përfshin një ndërfaqe grafike të përdoruesit ku përdoruesit mund të shkruajnë emrin e përdoruesit dhe fjalëkalimin e tyre, dhe aplikacioni gjeneron një çelës të derivuar për ruajtje apo krahasim të sigurt.
Përdorimi
1.	Shkruani emrin e përdoruesit dhe fjalëkalimin në fushat e dhëna të dhëna.
2.	Pas klikimit të butonit “Login” në prapavijë algoritmi krijon një celës të derivuar duke përdorur PBKDF2-SHA512.
3.	Çelësi i derivuar shfaqet në format heksadecimal për ruajtje apo krahasim.
4.	Për qëllime testimi, një dritare mesazhi shfaq çelësin e derivuar.
Përmbledhja e Kodit
Funksionaliteti kryesor i aplikacionit është implementuar në klasën Form1. Këtu janë komponentët kyçe:
•	Gjenerimi i Kripës: Metoda GenerateSalt krijon një kripë të rastësishme të gjatësisë së caktuar.
•	Gjenerimi i Çelësit të Derivuar: Metoda GenerateDerivedKey përdor klasën Rfc2898DeriveBytes për të derivuar një çelës nga fjalëkalimi, kripa, iteracionet dhe algoritmi i hashimit SHA-512.
•	Ngjarja e Klikimit të Butonit të Login: Trajton ngjarjen button_login_Click duke kapur emrin dhe fjalëkalimin e shkruar, duke krijuar një çelës të derivuar dhe duke e shfaqur atë në një dritare mesazhi.
