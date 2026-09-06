# Popotte — migration .NET 10, pass4

## Résultat
La solution a été compilée le 5 septembre 2026 sous Windows avec le SDK .NET 10.0.400 :
- Debug | x64 : réussite, 0 erreur, 5 avertissements.
- Release | x64 : réussite, 0 erreur, 5 avertissements.
Les deux projets, Popotte et ExtendedRichTextBox (AdvRTB), sont compilés.
L'interface, le démarrage et les fonctions métier n'ont pas été testés en exécution.

## Corrections depuis la pass3
- Imports VB globaux System, System.Drawing et System.Windows.Forms dans les deux projets.
- Attribut d'assembly SupportedOSPlatform("windows6.1") explicite dans PlatformSupport.vb, car GenerateAssemblyInfo reste désactivé pour conserver les métadonnées historiques. Cet attribut décrit les API utilisées ; il ne garantit pas que .NET 10 fonctionne sur Windows 7.
- Qualification des 26 références abrégées Windows.Forms en Global.System.Windows.Forms pour éviter les ambiguïtés de résolution du namespace.
- dlgLivres : remplacement de Closing par FormClosing avec FormClosingEventArgs ; le bouton Fermer appelle Close(), qui déclenche le gestionnaire.
- Aucun nouvel avertissement n'a été masqué.

## Ouvrir et compiler
Extraire l'archive dans un nouveau dossier, puis ouvrir Popotte\Popotte.sln dans un Visual Studio compatible avec le SDK .NET 10.
Choisir Debug ou Release, plateforme x64, puis reconstruire la solution.

Commandes depuis le dossier Popotte :
```powershell
dotnet build Popotte.sln -c Debug -p:Platform=x64
dotnet build Popotte.sln -c Release -p:Platform=x64
```
Pour les validations effectuées dans l'environnement isolé, un profil temporaire et une configuration NuGet sans source ont été utilisés, ainsi que -p:TargetPlatformDisplayName=Windows. Ces réglages évitent l'accès aux dossiers de configuration personnels et ne modifient pas le code compilé. Aucune dépendance NuGet externe n'a été nécessaire.

## Avertissements restants
- EncryptionSHA1.vb : 2 SYSLIB0060 (constructeur Rfc2898DeriveBytes) et 2 SYSLIB0022 (RijndaelManaged). La modernisation doit vérifier la compatibilité avec les recettes déjà chiffrées avant de modifier les algorithmes.
- frmMain.vb, is_unicode : 1 CA2022, car la lecture de l'en-tête ne vérifie pas le nombre d'octets lus.

## Vérifications fonctionnelles à effectuer
- Démarrer Popotte et ouvrir les fenêtres Livres et Recherche.
- Ouvrir, modifier et enregistrer une recette ; fermer la fenêtre Livres.
- Vérifier impression, import/export ZIP et déchiffrement de données existantes sur des copies.
- Vérifier séparément l'ancien système de mise à jour et le script d'installation : cette passe ne valide pas leur fonctionnement.

## Contenu
Sources et ressources de la pass3 avec les corrections ci-dessus. Les dossiers bin, obj, .vs et .git et les fichiers utilisateur Visual Studio sont exclus. Cette archive contient les sources, pas une distribution autonome.

## Références
- Imports VB : https://learn.microsoft.com/en-us/visualstudio/ide/how-to-add-or-remove-imported-namespaces-visual-basic
- Attribut Windows et CA1416 : https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1416
