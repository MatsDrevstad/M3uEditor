# M3uEditor
Rensa kanaler som man inte vill ha på IPTV

Om den inte komplierar
a) Kolla först .NET version som din dator har. I solution Explorer högerklicka på M3UEditior och välj proprerties. Under Application General.

eller
b) uppdatera M3uEditor.csproj och taggen TargetFramework/netcoreapp2.1

Sökväg till 
.m3u (original), 
filter.txt, 
upload.m3u (resultat)
I M3uApplication.cs filen behöver du ändra sökväg till filen filter.txt
(original).m3u ska ligga i samma map och även upload.m3u kommer hamna där.

I filter.txt lägger du allt du vill exkludera från kanallistan. Exempelvis..
ARAB
AS
ASIA
AT

Du kan ha olika namn på olika filter. Programet läser alla .txt filer i samma mapp och läser in den första .txt filen som filter

Lycka till!
