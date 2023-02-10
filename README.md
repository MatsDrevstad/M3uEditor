# M3uEditor
Rensa kanaler som man inte vill ha på IPTV

Om den inte komplierar...
Kolla först .NET version som din dator har. I solution Explorer högerklicka på M3UEditio och välj proprerties. Under Application General; Target Framwork byt till exempelvis NET 6.0. (Onödigt att installera en version av NET bara för detta) men NET 6.0 ska funka.

Filen filter.txt och filen M3uApplication.cs
I .cs filen behöver du ändra sökväg till filen filter.txt

I filter.txt lägger du allt du vill exkludera från kanallistan.
Exempelvis) 
ARAB
AS
ASIA
AT
osv...

Du kan ha olika namn på olika filter. Programet läser alla .txt filer i samma mapp och läser in den första .txt filen som filter

Lycka till!
