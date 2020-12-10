using System;

namespace WebAPI.Models{

    public class GithubUser
    {

        public string login { get; set; }
        public string name { get; set; }
        public string avatar_url { get; set; }


    }
}

// {
//     "login": "dcmunhoz",
//     "id": 23061616,
//     "node_id": "MDQ6VXNlcjIzMDYxNjE2",
//     "avatar_url": "https://avatars1.githubusercontent.com/u/23061616?v=4",
//     "gravatar_id": "",
//     "url": "https://api.github.com/users/dcmunhoz",
//     "html_url": "https://github.com/dcmunhoz",
//     "followers_url": "https://api.github.com/users/dcmunhoz/followers",
//     "following_url": "https://api.github.com/users/dcmunhoz/following{/other_user}",
//     "gists_url": "https://api.github.com/users/dcmunhoz/gists{/gist_id}",
//     "starred_url": "https://api.github.com/users/dcmunhoz/starred{/owner}{/repo}",
//     "subscriptions_url": "https://api.github.com/users/dcmunhoz/subscriptions",
//     "organizations_url": "https://api.github.com/users/dcmunhoz/orgs",
//     "repos_url": "https://api.github.com/users/dcmunhoz/repos",
//     "events_url": "https://api.github.com/users/dcmunhoz/events{/privacy}",
//     "received_events_url": "https://api.github.com/users/dcmunhoz/received_events",
//     "type": "User",
//     "site_admin": false,
//     "name": "Daniel Munhoz",
//     "company": "Unimed Alta Mogiana",
//     "blog": "https://dcmunhoz.github.io/portfolio/",
//     "location": "Orlândia/SP - Brasil",
//     "email": null,
//     "hireable": true,
//     "bio": "Full Stack Developer 💙",
//     "twitter_username": null,
//     "public_repos": 19,
//     "public_gists": 1,
//     "followers": 0,
//     "following": 4,
//     "created_at": "2016-10-25T18:47:51Z",
//     "updated_at": "2020-12-09T21:09:23Z"
// }