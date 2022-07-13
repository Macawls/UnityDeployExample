---
marp: true
theme: gaia
---
<style>
    @import url('https://fonts.googleapis.com/css2?family=JetBrains+Mono:wght@400&display=swap');
    
    :root {
        --color-background: #282c34;
        --color-foreground: #949aa8;
        font-family: 'JetBrains Mono', monospace;
        color-scheme: dark;
        
    }

    img[alt~="center"] {
        display: block;
        margin: 0 auto;
    }

    h1 {
        font-size: 45px;
        color: #61afef;
    }

    h2 { font-size: 40px;}

    h3 { font-size: 30px;
    color: #c678dd;}

    h4 { 
        font-size: 25px;
        color: #98c379;
    }

    h5 { font-size: 20px;}

    h6 { font-size: 18px;}

    a {
        color: #e5c07b;
    }

    p {
        font-size: 28px;
    }

    ul {
        font-size: 32px;
        list-style: none;
        list-style-position: inside;
    }

    b, strong {
   color: #aab2be
    }

    
ul li::before {
  content: "\2022"; 
  color: #c678dd; /* Change the color */
  font-weight: bold;
  display: inline-block;
  size: 5em; 
  width: 1em;
  margin-left: -1em; 
}

</style>
[macawls]: https://github.com/macawls 
# CI/CD for your Unity Projects 

### Working more efficiently as a Game Developer
![h:380 center drop-shadow](https://i.imgur.com/NyXi2Xj.png) 


#### By Joshua Macauley ([@Macawls][macawls]) ![w:2em h:2em](https://avatars.githubusercontent.com/u/80009513?v=4) 
##### View the presentation in your browser at [macawls.dev/unitydeployexample](https://macawls.dev/unitydeployexample)

---

# A little bit about me 

![h:260 center](https://macawls.dev/apu-gallery/apu/happyandcomfy.png)

* I've always enjoyed messing with things!
* Linux and Open-Source :heart:
* DRY -> **Don't repeat yourself!**
* RTFM -> [Read the fucking manual](http://readthefuckingmanual.com/)

---
# Source Control is Important! <!--fit-->

For the love of all things holy **please use source control** when making a game in a team. 
![bg right:40% h:750 drop-shadow](https://media.giphy.com/media/cnhpl4IeYgU7MCBdV2/giphy.gif)

### Git is the most popular. 

Other good **options** for Unity include:
* [Plastic SCM(Built In)](https://docs.unity3d.com/Manual/PlasticSCMPlugin.html)
* [Perforce](https://www.perforce.com/)


---
# Lets outline the problem 

You're working with a **team of four** during the **Game Jam**.

Bob wants to **playtest** Timmy's **changes**.

**Adam**, the **artist** who **doesn't know how to use Github** wants to test the game.

![bg left:40% h:500 drop-shadow](https://media.giphy.com/media/XMC67UHffXHrUIJGpn/giphy.gif)


---





# The problem continued

There's a hour left, everyone is exhausted.

You have to manually fetch the latest change and build the project.

Suddenly there's a problem with the build without much time to fix it.

![bg right h:500 drop-shadow](https://i.giphy.com/efFHPJWv9tzuB6lDZs.gif)

--- 
# The Solution! What is CI/CD? <!--fit-->


![bg left:27% h:300](https://i.kym-cdn.com/photos/images/original/001/385/979/26b.png)

* CI - Continous Integration
* CD - Continous Deployment

### Definiton
"CI/CD is a method to frequently deliver apps to customers by introducing **automation** into the stages of app development."

### Why is it useful?
Deliver improvements and fixes **MUCH** faster and have the peace of mind your code is build ready and safe for production.

---
# Development and Operations Pipeline <!--fit-->
![center h:540](https://i.imgur.com/NyXi2Xj.png) 

---
# What is Github Actions? 
"GitHub Actions is a continuous integration and continuous delivery (CI/CD) platform that allows you to automate your build, test, and deployment pipeline."

![h:420 center](https://github.githubassets.com/images/modules/site/features/actions-workflow.svg)

___
# What can I do with GitHub Actions? 
### Many things!

![bg right:40% h:600](https://i.imgur.com/tKw28I3.png)
* Automatically **test** your game to make sure its ready for production.
* Automatically **build** your game on the cloud.
* Automatically **publish** your game to multiple stores!
---



# Is it all free?

### Pretty much!
https://github.com/pricing


The game in the example repository takes around **4 minutes** per **platform** (Windows, Web, Mac) to build and deploy.

With the **free 2000 CI/CD minutes limit** that equates to a maximum of around **160 builds per month**! 


![bg right:40% h:720](https://i.imgur.com/iIEdGWQ.jpg)

---

# What is this wizardry? 🧙‍♂️
<style scoped>
pre {
   font-size: 0.7rem;
}
</style>

```
- uses: actions/cache@v2
    with:
        path: Library
        key: Library-${{ matrix.targetPlatform }}
        restore-keys: Library- 
- uses: game-ci/unity-builder@v2
    env:
        UNITY_LICENSE: ${{ secrets.UNITY_LICENSE }}
    with:
        targetPlatform: ${{ matrix.targetPlatform }}
```
Quick to implement + easy to use = **abstraction**.

If you're interested in learning more, have a look at [Docker](https://www.docker.com/), which solves the problem of "It doesn't work on my machine!". 

![bg right:25% h:400](https://media.giphy.com/media/0KBiC2Q6Phwz2dkjCj/giphy.gif)








---
# Great! How do I get started? <!--fit-->
### Easy Peasy!

* Have a look at this repository and follow the instructions.
* Customize it to your use case.

https://github.com/Macawls/UnityDeployExample

![bg right:25%](https://media.giphy.com/media/rmi45iyhIPuRG/giphy.gif)
<br>

#### Discliamer: The contents of this repository is highly simplified.


---
# Hope you enjoyed! :v: <!--fit-->

## Good luck for the Game Jam!
![center h:330](https://macawls.dev/apu-gallery/apu/pepe.png)

#### <br>For any queries contact me at [josh@macawls.dev](mailto:josh@macawls.dev)

