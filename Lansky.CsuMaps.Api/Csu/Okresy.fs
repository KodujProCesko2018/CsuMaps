module Okresy

type OkresId =
    | OkresId of string

let value (OkresId o) = o

type Okres = {
    id : OkresId;
    name : string;
}

let okresList = [|
    { id = OkresId "0100"; name = "Praha" };
    { id = OkresId "0201"; name = "Benešov" };
    { id = OkresId "0202"; name = "Beroun" };
    { id = OkresId "0203"; name = "Kladno" };
    { id = OkresId "0204"; name = "Kolín" };
    { id = OkresId "0205"; name = "Kutná Hora" };
    { id = OkresId "0206"; name = "Mělník" };
    { id = OkresId "0207"; name = "Mladá Boleslav" };
    { id = OkresId "0208"; name = "Nymburk" };
    { id = OkresId "0209"; name = "Praha-východ" };
    { id = OkresId "020a"; name = "Praha-západ" };
    { id = OkresId "020b"; name = "Příbram" };
    { id = OkresId "020c"; name = "Rakovník" };
    { id = OkresId "0311"; name = "České Budějovice" };
    { id = OkresId "0312"; name = "Český Krumlov" };
    { id = OkresId "0313"; name = "Jindřichův Hradec" };
    { id = OkresId "0314"; name = "Písek" };
    { id = OkresId "0315"; name = "Prachatice" };
    { id = OkresId "0316"; name = "Strakonice" };
    { id = OkresId "0317"; name = "Tábor" };
    { id = OkresId "0321"; name = "Domažlice" };
    { id = OkresId "0322"; name = "Klatovy" };
    { id = OkresId "0323"; name = "Plzeň-město" };
    { id = OkresId "0324"; name = "Plzeň-jih" };
    { id = OkresId "0325"; name = "Plzeň-sever" };
    { id = OkresId "0326"; name = "Rokycany" };
    { id = OkresId "0327"; name = "Tachov" };
    { id = OkresId "0411"; name = "Cheb" };
    { id = OkresId "0412"; name = "Karlovy Vary" };
    { id = OkresId "0413"; name = "Sokolov" };
    { id = OkresId "0421"; name = "Děčín" };
    { id = OkresId "0422"; name = "Chomutov" };
    { id = OkresId "0423"; name = "Litoměřice" };
    { id = OkresId "0424"; name = "Louny" };
    { id = OkresId "0425"; name = "Most" };
    { id = OkresId "0426"; name = "Teplice" };
    { id = OkresId "0427"; name = "Ústí nad Labem" };
    { id = OkresId "0511"; name = "Česká Lípa" };
    { id = OkresId "0512"; name = "Jablonec nad Nisou" };
    { id = OkresId "0513"; name = "Liberec" };
    { id = OkresId "0514"; name = "Semily" };
    { id = OkresId "0521"; name = "Hradec Králové" };
    { id = OkresId "0522"; name = "Jičín" };
    { id = OkresId "0523"; name = "Náchod" };
    { id = OkresId "0524"; name = "Rychnov nad Kněžnou" };
    { id = OkresId "0525"; name = "Trutnov" };
    { id = OkresId "0531"; name = "Chrudim" };
    { id = OkresId "0532"; name = "Pardubice" };
    { id = OkresId "0533"; name = "Svitavy" };
    { id = OkresId "0534"; name = "Ústí nad Orlicí" };
    { id = OkresId "0711"; name = "Jeseník" };
    { id = OkresId "0712"; name = "Olomouc" };
    { id = OkresId "0713"; name = "Prostějov" };
    { id = OkresId "0714"; name = "Přerov" };
    { id = OkresId "0715"; name = "Šumperk" };
    { id = OkresId "0641"; name = "Blansko" };
    { id = OkresId "0642"; name = "Brno-město" };
    { id = OkresId "0643"; name = "Brno-venkov" };
    { id = OkresId "0644"; name = "Břeclav" };
    { id = OkresId "0645"; name = "Hodonín" };
    { id = OkresId "0646"; name = "Vyškov" };
    { id = OkresId "0647"; name = "Znojmo" };
    { id = OkresId "0631"; name = "Havlíčkův Brod" };
    { id = OkresId "0632"; name = "Jihlava" };
    { id = OkresId "0633"; name = "Pelhřimov" };
    { id = OkresId "0634"; name = "Třebíč" };
    { id = OkresId "0635"; name = "Žďár nad Sázavou" };
    { id = OkresId "0721"; name = "Kroměříž" };
    { id = OkresId "0722"; name = "Uherské Hradiště" };
    { id = OkresId "0723"; name = "Vsetín" };
    { id = OkresId "0724"; name = "Zlín" };
    { id = OkresId "0801"; name = "Bruntál" };
    { id = OkresId "0805"; name = "Opava" };
    { id = OkresId "0806"; name = "Ostrava-město" };
    { id = OkresId "0803"; name = "Karviná" };
    { id = OkresId "0802"; name = "Frýdek-Místek" };
    { id = OkresId "0804"; name = "Nový Jičín" };
|]