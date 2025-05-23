<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a id="readme-top"></a>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
<!--
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![project_license][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
-->


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/jordanhwong/Task_Tracker">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Task Tracker</h3>

  <p align="center">
    As based on <a href="https://roadmap.sh/projects/task-tracker">roadmap.sh</a> specifications
    <br />
    <a href="https://github.com/jordanhwong/Task_Tracker"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/jordanhwong/Task_Tracker/issues/new?labels=bug&template=bug-report---.md">Report Bug</a>
    &middot;
    <a href="https://github.com/jordanhwong/Task_Tracker/issues/new?labels=enhancement&template=feature-request---.md">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

[![Task Tracker Screen Shot][product-screenshot]](https://roadmap.sh/projects/task-tracker)

This task tracker can handle basic operations, stored in a json file. Operations include the following:
* <b>Add a task</b>: Appends a new task with description to the end of the tracker.
* <b>Update a task</b>: Updates the description of a task based on ID.
* <b>Delete a task</b>: Deletes a task based on ID, shifting task IDs after it.
* <b>Mark a task</b>: Mark a task baed on ID to either in-progress or done.
* <b>List</b>: Lists all tasks be default, or all tasks of a certain status.
* <b>Help</b>: Lists all possible commands.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built in

* C# .NET

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

Due to the basic nature of this project, it is likely that cloning this repository should allow you to run the project just fine. However, for completionism it can noted that <a href="https://dotnet.microsoft.com/en-us/download">C# .NET</a> is required, and can be downloaded via the launcher through the hyperlink.

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/jordanhwong/Task_Tracker.git
   ```
2. Build the project
    ```sh
    dotnet build
    ```
3. Change git remote url to avoid accidental pushes to base project
   ```sh
   git remote set-url origin <NEW_GIT_URL_HERE>
   git remote -v # confirm the changes
   ```
4. Run the project with specified arguments
    ```sh
    dotnet run <command> <args>
    ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

To run, use .NET's CLI compiler with the action you wish to do. 
```sh
dotnet run <command> <args>
```
Below is example usage of the program:
```sh
dotnet run add "Clean the bathroom"
Task added successfully: (ID: 1)

dotnet run list              
ID: 1, Description: Clean the bathroom, Status: ToDo, Created At: 5/22/2025 9:35:17 PM, Updated At: 5/22/2025 9:35:17 PM

dotnet run mark-done 1
Task ID 1 status updated to Done.

dotnet run list done  
ID: 1, Description: Clean the bathroom, Status: Done, Created At: 5/22/2025 9:35:17 PM, Updated At: 5/22/2025 9:37:20 PM
```

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- 
ROADMAP
## Roadmap

- [ ] Feature 1
- [ ] Feature 2
- [ ] Feature 3
    - [ ] Nested Feature

See the [open issues](https://github.com/jordanhwong/Task_Tracker/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>
 -->


<!-- CONTRIBUTING
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p> -->

<!-- ### Top contributors:

<a href="https://github.com/jordanhwong/Task_Tracker/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=github_username/repo_name" alt="contrib.rocks image" />
</a> -->


<!-- 
LICENSE
## License

Distributed under the project_license. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>
 -->


<!-- CONTACT -->
## Contact

Jordan Wong -  jordanhwong1@gmail.com

Project Link: [https://github.com/jordanhwong/Task_Tracker](https://github.com/jordanhwong/Task_Tracker)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- 

 ACKNOWLEDGMENTS 
## Acknowledgments

* []()
* []()
* []()

<p align="right">(<a href="#readme-top">back to top</a>)</p> 
-->



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/github_username/repo_name.svg?style=for-the-badge
[contributors-url]: https://github.com/jordanhwong/Task_Tracker/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/github_username/repo_name.svg?style=for-the-badge
[forks-url]: https://github.com/jordanhwong/Task_Tracker/network/members
[stars-shield]: https://img.shields.io/github/stars/github_username/repo_name.svg?style=for-the-badge
[stars-url]: https://github.com/jordanhwong/Task_Tracker/stargazers
[issues-shield]: https://img.shields.io/github/issues/github_username/repo_name.svg?style=for-the-badge
[issues-url]: https://github.com/jordanhwong/Task_Tracker/issues
[license-shield]: https://img.shields.io/github/license/github_username/repo_name.svg?style=for-the-badge
[license-url]: https://github.com/jordanhwong/Task_Tracker/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/jordanhwong
[product-screenshot]: images/screenshot.png
[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 
