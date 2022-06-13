### Setting Up a Repository for Unity
![](https://cdn.frankerfacez.com/emoticon/236895/2) \
An alternative is [GitHub Desktop](https://desktop.github.com/), which makes this process much easier

Initialize the repository at the root of the project.
```bash
git init
```
Use a .gitignore file to tell git which files to ignore. \
Here's a repo with a bunch of templates https://github.com/github/gitignore
```
wget https://macawls.dev/unityfiles/gitignore -o ".gitignore"
```
[Download Git LFS](https://git-lfs.github.com/) \
Install LFS in your repository.
```
git lfs install
```
Use a .gitattributes file for LFS to tell it which files to track.
```
wget https://macawls.dev/unityfiles/gitattributes -o ".gitattributes"
```
All done! Have a look using:
```
git status
```
### Building and Deploying to Itch.IO with GitHub Actions