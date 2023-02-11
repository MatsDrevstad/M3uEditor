# M3uEditor
Rensa kanaler som man inte vill ha på IPTV

Om den inte komplierar...
a) Kolla först .NET version som din dator har. I solution Explorer högerklicka på M3UEditio och välj proprerties. Under Application General; Target Framwork byt till exempelvis NET 6.0. (Onödigt att installera en version av NET bara för detta) men NET 6.0 ska funka.

ellse..
b) ändra i filen M3uEditor.csproj <TargetFramework>netcoreapp2.1</TargetFramework>

Sökväg till .m3u (original), filter.txt, upload.m3u (resultat)
I M3uApplication.cs filen behöver du ändra sökväg till filen filter.txt
Original ska ligga i samma map och även upload.m3u kommer hamna där.

I filter.txt lägger du allt du vill exkludera från kanallistan. Exempelvis..
ARAB
AS
ASIA
AT

Du kan ha olika namn på olika filter. Programet läser alla .txt filer i samma mapp och läser in den första .txt filen som filter

Lycka till!
