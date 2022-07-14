<h2 align="center">Presentation</h2><hr/>

https://macawls.dev/unitydeployexample/

<h2 align="center">Docs and Resources</h2><hr/>

[![Build, Test and Deploy 💻](https://github.com/Macawls/unitydeployexample/actions/workflows/main.yml/badge.svg?branch=based)](https://github.com/Macawls/unitydeployexample/actions/workflows/main.yml)

* [Game CI Link](https://game.ci/)
* [Youtube Tutorial by Rohan Mayya](https://youtu.be/JjKCy3H0A30)
* [Marp for Presentation](https://marp.app/)
* [David Finol Website](https://davidmfinol.website/)

<h2 align="center">Setting Up a Repository for Unity</h2><hr/>

![](https://cdn.frankerfacez.com/emoticon/236895/2) \
An alternative is [GitHub Desktop](https://desktop.github.com/), which makes this process much easier and allows you to skip some steps.

Initialize the repository at the root of the project.
```bash
git init
```
Use a .gitignore file to tell git which files to ignore. \
Here's a repo with a bunch of templates https://github.com/github/gitignore
```
wget https://raw.githubusercontent.com/Macawls/unitydeployexample/based/.gitignore -o ".gitignore"
```
[Download Git LFS](https://git-lfs.github.com/) \
Install LFS in your repository:
```
git lfs install
```
Use a .gitattributes file for LFS to tell it which files to track.
```
wget https://raw.githubusercontent.com/Macawls/unitydeployexample/based/.gitattributes -o ".gitattributes"
```
All done! Have a look at which files are going to be tracked using:
```
git status
```

<h2 align="center">Building and Deploying to Itch.IO with GitHub Actions</h2><hr/>

![](https://cdn.frankerfacez.com/emoticon/218530/2)
### Testing


It's best practice to test your project before building your game to increase reliability and confidence in merging changes. 

<h2 align="center">Unity License Setup</h2><hr/>

We need to tell Unity we're legit.
Create a file at **.github/workflows/activation.yml** and push your changes. You'll only need to run this once.

```yml
name: Acquire activation file
on:
  workflow_dispatch: {}
jobs:
  activation:
    name: Request manual activation file 🔑
    runs-on: ubuntu-latest
    steps:
      # Request manual activation file
      - name: Request manual activation file
        id: getManualLicenseFile
        uses: game-ci/unity-request-activation-file@v2
      # Upload artifact (Unity_v20XX.X.XXXX.alf)
      - name: Expose as artifact
        uses: actions/upload-artifact@v2
        with:
          name: ${{ steps.getManualLicenseFile.outputs.filePath }}
          path: ${{ steps.getManualLicenseFile.outputs.filePath }}
```
The workflow is meant to be run manually, defined by
```yml
on:
  workflow_dispatch: {}
```
Run the workflow under the actions tab and download the artifact once it's done.

Sign into [Unity License](https://license.unity3d.com/) with your credentials and upload the artifact.

You should now receive your license file (Unity_v20XX.x.ulf).

Head over to the settings tab of your Github repository. 

Create the following **Secrets** under your repository settings
* UNITY_LICENSE - (Contents of your downloaded license file)
* UNITY_EMAIL - (Unity email address)
* UNITY_PASSWORD - (Unity password)

Make sure this is step is completed before continuing.

<h2 align="center">Setting Up Itch.IO</h2><hr/>

[Create a new Itch.Io Page](https://itch.io/game/new).

Note the name of the game, for example at this url
https://macawls.itch.io/deployexample the name would be "deployexample".

Create a new Itch.io API key [here](https://itch.io/user/settings/api-keys)
and store that value as a secret named **"BUTLER_CREDENTIALS"**.


<h2 align="center">Building and Deploying</h2><hr/> 

Create a file at **.github/workflows/main.yml** and copy the contents of
[this file](https://github.com/Macawls/UnityDeployExample/blob/based/.github/workflows/main.yml).

Use the values from the previous step in the this section of the file.
```yml
# Publish to Itch.IO
- uses: manleydev/butler-publish-itchio-action@master
  env:
    BUTLER_CREDENTIALS: ${{ secrets.BUTLER_CREDENTIALS }}
    CHANNEL: ${{ matrix.targetPlatform }}
    ITCH_GAME: <Name of the Game>
    ITCH_USER: <Your Itch.Io Username>
    PACKAGE: build/${{ matrix.targetPlatform }}
```
Decide which platforms you'd like to publish to.

Only use the [allowed](https://docs.unity3d.com/ScriptReference/BuildTarget.html) platform names.
```yml
  buildForAllSupportedPlatforms:
    name: Build and Deploy for ${{ matrix.targetPlatform }}
    runs-on: ubuntu-latest
    strategy:
      fail-fast: false # if one build fails, other platforms will still be built
      matrix:
        targetPlatform:
          - StandaloneWindows64
          - WebGL
          - StandaloneOSX #etc
```
* * *
<h2 align="center">All Done!</h2>

![]() 
<p align="center">
  <img src="https://cdn.betterttv.net/emote/603c008d7c74605395f360da/3x">
</p>
If you want to embed the WebGL build to your Itch.IO Page tick this checkbox. You'll only need to do this <strong>once</strong> because the build is tied to the WebGL <strong>channel</strong> in Itch.Io.

![](https://i.imgur.com/i5OoZXF.png)

