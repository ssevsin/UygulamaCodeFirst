insert into Kullanicis (Ad,Soyad,Il,Ilce,Tutar,BorcluMu,Aciklama) Values('Mert','Gürler','Adana','Kozan','400','0','Deneme')

update Kullanicis set Ad='Deniz',Soyad='Korkmaz' where Ad='Deniz'

delete from Kullanicis where ID=5

select * from Kullanicis where BorcluMu=1;

select sum(Tutar) from Kullanicis where BorcluMu=0

select * from Kullanicis