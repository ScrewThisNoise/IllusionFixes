# Illusion Fixes
A collection of fixes for common issues found in Koikatu, Koikatsu Party, EmotionCreators, and AI Girl

## How to install
1. Install the latest build of [BepInEx](https://builds.bepis.io/projects/bepinex_be) and latest release of [BepisPlugins](https://github.com/IllusionMods/BepisPlugins/releases).
2. Grab the [latest release](https://github.com/IllusionMods/IllusionFixes/releases) for your game from releases tab above (Koikatu and Koikatsu Party share the same release).
3. Extract the BepInEx folder from the release into your game directory, overwrite when asked.
4. Run the game and look for any errors on the screen, asking you to remove some old plugins. All of the listed plugins have been replaced by their updated versions in this fix pack, and need to be removed after closing the game. *Plugins from this pack will not work until all of the old versions are removed.*

*Note for Koikatsu Party users: You can skip KK_Fix_CharacterListOptimizations.dll as it will not work with party. It can produce an error during load in Koikatsu Party, but the error is harmless and can be safely ignored.*

## Plugin descriptions
### CameraTargetFix
(Koikatsu, PlayHome, AI Girl)
Hides the cursor when the camera target is disabled in Studio. In AI Girl, also makes the camera target option in the game settings work properly for the character maker.

### CardImport
(EmotionCreators)

Prevents the game from crashing or stripping some modded data when importing KK cards.

### CharacterListOptimizations 
(Koikatsu)

Makes character lists load faster.

### CenteredHSceneCursor 
(Koikatsu)

Fixes the cursor texture not being properly centeres in H scenes, so it's easier to click on things.

### DownloadRenamer
(EmotionCreators)

Maps, scenes, poses, and characters downloaded in game will have their file names changed to match the ones on the Illusion website.

### ExpandShaderDropdown 
(Koikatsu, EmotionCreators)

Makes the shader drop down menu extend down instaed of up and expands it. Necessary to select modded shaders since they run off the screen by default.

### HeterochromiaFix
(Koikatsu, EmotionCreators)

Allows you to load characters with different iris types without them being reset

### InvalidSceneFileProtection
(Koikatsu, AI Girl)

Adds error handling to scene loading and importing. If a scene is invalid or from the wrong game version then a message is shown and the studio doesn't crash.

### LoadingFixes
(AI Girl)

Fixes some studio scenes failing to load (sometimes you can't load the scene you've just saved with the stock game, many scenes on uploader are like this). Also fixes color picker breaking in maker because of a similar issue.

### MainGameOptimizations 
(Koikatsu)

Multiple performance optimizations for the story mode. Aimed to reduce stutter and random FPS drops.

### MakerOptimizations 
(Koikatsu, EmotionCreators)

Multiple performance optimizations for the character maker. Can greatly increase FPSMultiple performance optimizations for the character maker. Can greatly increase FPS, makes turning on/off the interface in maker by pressing space much faster (after the 1st press), and more.

### ManifestCorrector
(Koikatsu, EmotionCreators, AI Girl)

Prevents mods that use incorrect data in the MainManifest column of item lists from locking up the game in story mode.

### ModdedHeadEyeliner 
(Koikatsu)

Fixes modded head eyeliners not working on other head types than default.

### NewGameShowAllCards
(AI Girl)

Fixes downloaded character cards not appearing in the New Game character selection (so you don't have to go to maker and re-save them).

### NodeEditorUnlock
(EmotionCreators)

### NullChecks 
(Koikatsu, EmotionCreators)

Fixes for some questionably made mods causing issues.

### PartyCardCompatibility 
(Koikatsu)

Allows loading of cards saved in Koikatsu Party (Steam release) in Koikatu and Studio.

### PersonalityCorrector 
(Koikatsu)

Prevents cards with invalid or missing personalities from crashing the game. A default personality is set instead.

### PoseLoad
(Koikatsu)

Corrects Honey Select poses loaded in Koikatsu and prevents errors.

### ResourceUnloadOptimizations 
(Koikatsu, EmotionCreators, HoneySelect, AI Girl, PlayHome)

Improves loading times and eliminates stutter after loading was "finished".

### SettingsVerifier 
(Koikatsu, AI Girl)

Prevents corrupted setting from causing issues and forces studio to use the settings.xml file instead of registry.

### ShowerAccessories 
(Koikatsu)

Prevents accessories from being removed in shower peeping mode. No more gaping holes in the head when using hair accessories.

### UnlimitedMapLights 
(Koikatsu)

Allows using an unlimited amount of map lights in studio. Not all items support more than 3 lights.

## Patcher descriptions
### CultureFix
(EmotionCreators, AI Girl)

Set process culture to ja-JP, similarly to a locale emulator. Fixes game crashes and lockups on some system locales.
### MagicCarrot
Prevents the game from locking up when starting
