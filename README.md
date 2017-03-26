# vscode
Visual Studio Code presentation originally for the OKC# user group.


[Slides](https://cdn.rawgit.com/MrOnosa/vscode/master/reveal.js/index.html#/)

## To the cloners

Of course, I recommend using Visual Studio Code to work with this presentation.  
To get `reveal.js` working:
 * Open the terminal
    - Press `ctrl`+`shift`+`p` and type `Terminal: Focus Terminal` (I'm expecting it to say "cmd.exe" in the drop-down on the top right, so I'll be listing Command Line commands)
* You will need NPM v4 or greater to serve `reveal.js`
    - (tip) If you have [Node.js](https://nodejs.org/) installed, you could type `npm install -g npm` to install the latest version of NPM globally.
* Type `cd reveal.js` and press enter
* Type `npm install` and press enter
* I have made a custom Visual Studio Code task to serve the presentation.
    - Press `ctrl`+`shift`+`p` and type `Tasks: Run Task` and press enter
    - Select `serve VS Code Presentation`
* (Optional) Press `s` to see the speaker notes.