insert into Palvelu(toimipiste_id, nimi, kuvaus, hinta, alv)
values(1, 'Saarijärventie 35', 'Järven ranta mökki', 1000, 240),
(3, 'Teiskontie 60', 'Vesiskootteri', 100, 24),
(6, 'Oulunjärventie 7', 'airsoftaus', 30, 7.2);

select Palvelu.nimi as Nimi, Palvelu.kuvaus as Kuvaus, Palvelu.hinta as 'Hinta(Alv 24%)', Palvelu.alv as Alv, Toimipiste.nimi as Toimipaikka
from Palvelu
inner join Toimipiste on Palvelu.toimipiste_id=Toimipiste.toimipiste_id;