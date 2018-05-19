insert into varaus(asiakas_id, toimipiste_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm)
	values(1, 3, '2018-01-01 00:00:00', '2018-01-01 00:00:00', '2018-01-01 00:00:00', '2018-01-01 00:00:00');

select Toimipiste.toimipiste_id, Toimipiste.nimi as Toimipiste, Toimipiste.lahiosoite as toimipisteen_osoite, Toimipiste.postitoimipaikka as toimipisteen_postitoimipaikka, Toimipiste.postinro toimipisteen_postinro, Toimipiste.email as toimipisteen_email, Toimipiste.puhelinnro as toimipisteen_puhelinnro, Toimipiste.nimi as Toimipaikka, Varaus.varaus_id, Varaus.varattu_pvm, Varaus.vahvistus_pvm, Varaus.varattu_alkupvm, Varaus.varattu_loppupvm, Asiakas.asiakas_id, Asiakas.etunimi, Asiakas.sukunimi, Asiakas.lahiosoite, Asiakas.postitoimipaikka, Asiakas.postinro, Asiakas.email, Asiakas.puhelinnro
                    from Varaus
                    inner join Toimipiste on Varaus.toimipiste_id = Toimipiste.toimipiste_id
                    inner join Asiakas on Varaus.asiakas_id = Asiakas.asiakas_id;
                              
