


<!DOCTYPE html>
<html lang="en" class="">
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    
    
    <title>CSharp-Part-1/README.md at master · TelerikAcademy/CSharp-Part-1</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png">
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png">
    <meta property="fb:app_id" content="1401488693436528">

      <meta content="@github" name="twitter:site" /><meta content="summary" name="twitter:card" /><meta content="TelerikAcademy/CSharp-Part-1" name="twitter:title" /><meta content="CSharp-Part-1 - Repository for the course &amp;quot;C# part 1&amp;quot;" name="twitter:description" /><meta content="https://avatars2.githubusercontent.com/u/1455020?v=3&amp;s=400" name="twitter:image:src" />
      <meta content="GitHub" property="og:site_name" /><meta content="object" property="og:type" /><meta content="https://avatars2.githubusercontent.com/u/1455020?v=3&amp;s=400" property="og:image" /><meta content="TelerikAcademy/CSharp-Part-1" property="og:title" /><meta content="https://github.com/TelerikAcademy/CSharp-Part-1" property="og:url" /><meta content="CSharp-Part-1 - Repository for the course &quot;C# part 1&quot;" property="og:description" />
      <meta name="browser-stats-url" content="https://api.github.com/_private/browser/stats">
    <meta name="browser-errors-url" content="https://api.github.com/_private/browser/errors">
    <link rel="assets" href="https://assets-cdn.github.com/">
    <link rel="web-socket" href="wss://live.github.com/_sockets/NTgzMTQ2NjoyYmZlYjM4MDhkNmQwZjQyNTU0YTVlNzZhNzEyNzg4NToxM2UyYmVjODQxY2M5NTlkZDVkNTJmNjQ2OWI2NzgwMTQ2MzY4MzUwYTFmOTljMTNiMWE1ZWFkNjQyZDZiM2Yy--25d1a4ecb82ee7abaa5f88408c936d62335d81bf">
    <meta name="pjax-timeout" content="1000">
    <link rel="sudo-modal" href="/sessions/sudo_modal">

    <meta name="msapplication-TileImage" content="/windows-tile.png">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="selected-link" value="repo_source" data-pjax-transient>
      <meta name="google-analytics" content="UA-3769691-2">

    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="D4059E29:1B11:7517A7:5527C733" name="octolytics-dimension-request_id" /><meta content="5831466" name="octolytics-actor-id" /><meta content="TanyaPetkova" name="octolytics-actor-login" /><meta content="46b455f3f938ffd443aba14440051a0f219bb89243035e45c4b02f721bcbe518" name="octolytics-actor-hash" />
    
    <meta content="Rails, view, blob#show" name="analytics-event" />
    <meta class="js-ga-set" name="dimension1" content="Logged In">
    <meta class="js-ga-set" name="dimension2" content="Header v3">
    <meta name="is-dotcom" content="true">
    <meta name="hostname" content="github.com">
    <meta name="user-login" content="TanyaPetkova">

    
    <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">


    <meta content="authenticity_token" name="csrf-param" />
<meta content="uy7cf6mSRX9RHBaU6XYiInVs2rZMLVzScAqFyGO5iU6VxuHoKCxMH6mqAelcbZazZq/80hcXDDLPnaE7u0BvnQ==" name="csrf-token" />

    <link href="https://assets-cdn.github.com/assets/github-6a4174aa7e25ce4268078491fdfa22273eef841d99e1ab07ccce9b89c747f55d.css" media="all" rel="stylesheet" />
    <link href="https://assets-cdn.github.com/assets/github2-5b5e999e041f2586f9dc06b940229076225e6ec5ab5406be292a87331325fdc0.css" media="all" rel="stylesheet" />
    
    


    <meta http-equiv="x-pjax-version" content="8ef4cce20ae9cf017054cfeff04ce121">

      
  <meta name="description" content="CSharp-Part-1 - Repository for the course &quot;C# part 1&quot;">
  <meta name="go-import" content="github.com/TelerikAcademy/CSharp-Part-1 git https://github.com/TelerikAcademy/CSharp-Part-1.git">

  <meta content="1455020" name="octolytics-dimension-user_id" /><meta content="TelerikAcademy" name="octolytics-dimension-user_login" /><meta content="28328936" name="octolytics-dimension-repository_id" /><meta content="TelerikAcademy/CSharp-Part-1" name="octolytics-dimension-repository_nwo" /><meta content="true" name="octolytics-dimension-repository_public" /><meta content="false" name="octolytics-dimension-repository_is_fork" /><meta content="28328936" name="octolytics-dimension-repository_network_root_id" /><meta content="TelerikAcademy/CSharp-Part-1" name="octolytics-dimension-repository_network_root_nwo" />
  <link href="https://github.com/TelerikAcademy/CSharp-Part-1/commits/master.atom" rel="alternate" title="Recent Commits to CSharp-Part-1:master" type="application/atom+xml">

  </head>


  <body class="logged_in  env-production windows vis-public page-blob">
    <a href="#start-of-content" tabindex="1" class="accessibility-aid js-skip-to-content">Skip to content</a>
    <div class="wrapper">
      
      
      


        <div class="header header-logged-in true" role="banner">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/" data-hotkey="g d" aria-label="Homepage" data-ga-click="Header, go to dashboard, icon:logo">
  <span class="mega-octicon octicon-mark-github"></span>
</a>


      <div class="site-search repo-scope js-site-search" role="search">
          <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/search" class="js-site-search-form" data-global-search-url="/search" data-repo-search-url="/TelerikAcademy/CSharp-Part-1/search" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
  <input type="text"
    class="js-site-search-field is-clearable"
    data-hotkey="s"
    name="q"
    placeholder="Search"
    data-global-scope-placeholder="Search GitHub"
    data-repo-scope-placeholder="Search"
    tabindex="1"
    autocapitalize="off">
  <div class="scope-badge">This repository</div>
</form>
      </div>

      <ul class="header-nav left" role="navigation">
          <li class="header-nav-item explore">
            <a class="header-nav-link" href="/explore" data-ga-click="Header, go to explore, text:explore">Explore</a>
          </li>
            <li class="header-nav-item">
              <a class="header-nav-link" href="https://gist.github.com" data-ga-click="Header, go to gist, text:gist">Gist</a>
            </li>
            <li class="header-nav-item">
              <a class="header-nav-link" href="/blog" data-ga-click="Header, go to blog, text:blog">Blog</a>
            </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="https://help.github.com" data-ga-click="Header, go to help, text:help">Help</a>
          </li>
      </ul>

      
<ul class="header-nav user-nav right" id="user-links">
  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link name" href="/TanyaPetkova" data-ga-click="Header, go to profile, text:username">
      <img alt="@TanyaPetkova" class="avatar" data-user="5831466" height="20" src="https://avatars3.githubusercontent.com/u/5831466?v=3&amp;s=40" width="20" />
      <span class="css-truncate">
        <span class="css-truncate-target">TanyaPetkova</span>
      </span>
    </a>
  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link js-menu-target tooltipped tooltipped-s" href="/new" aria-label="Create new..." data-ga-click="Header, create new, icon:add">
      <span class="octicon octicon-plus"></span>
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      <ul class="dropdown-menu">
        
<li>
  <a href="/new" data-ga-click="Header, create new repository, icon:repo"><span class="octicon octicon-repo"></span> New repository</a>
</li>
<li>
  <a href="/organizations/new" data-ga-click="Header, create new organization, icon:organization"><span class="octicon octicon-organization"></span> New organization</a>
</li>


  <li class="dropdown-divider"></li>
  <li class="dropdown-header">
    <span title="TelerikAcademy/CSharp-Part-1">This repository</span>
  </li>
    <li>
      <a href="/TelerikAcademy/CSharp-Part-1/issues/new" data-ga-click="Header, create new issue, icon:issue"><span class="octicon octicon-issue-opened"></span> New issue</a>
    </li>

      </ul>
    </div>
  </li>

  <li class="header-nav-item">
        <a href="/notifications" aria-label="You have unread notifications" class="header-nav-link notification-indicator tooltipped tooltipped-s" data-ga-click="Header, go to notifications, icon:unread" data-hotkey="g n">
        <span class="mail-status unread"></span>
        <span class="octicon octicon-inbox"></span>
</a>
  </li>

  <li class="header-nav-item">
    <a class="header-nav-link tooltipped tooltipped-s" href="/settings/profile" id="account_settings" aria-label="Settings" data-ga-click="Header, go to settings, icon:settings">
      <span class="octicon octicon-gear"></span>
    </a>
  </li>

  <li class="header-nav-item">
    <form accept-charset="UTF-8" action="/logout" class="logout-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="9m763uihmPmjHcQi/9go+wgZuICM68UiEhzEFuH2/CY+fLUfSelGh3ieiJ7DvnFtZLuSAm8oLBqOYdeBakMYvg==" /></div>
      <button class="header-nav-link sign-out-button tooltipped tooltipped-s" aria-label="Sign out" data-ga-click="Header, sign out, icon:logout">
        <span class="octicon octicon-sign-out"></span>
      </button>
</form>  </li>

</ul>



    
  </div>
</div>

        

        


      <div id="start-of-content" class="accessibility-aid"></div>
          <div class="site" itemscope itemtype="http://schema.org/WebPage">
    <div id="js-flash-container">
      
    </div>
    <div class="pagehead repohead instapaper_ignore readability-menu">
      <div class="container">
        
<ul class="pagehead-actions">

  <li>
      <form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="h9FSbfQx1rFfRqbEYfIgcEtE5HPVsxzXau4F3SnoDkcnzn+kXUGc9jBmNPMgQ0FyKX4HbnTpXFsdRxGLqvLkVA==" /></div>    <input id="repository_id" name="repository_id" type="hidden" value="28328936" />

      <div class="select-menu js-menu-container js-select-menu">
        <a href="/TelerikAcademy/CSharp-Part-1/subscription"
          class="btn btn-sm btn-with-count select-menu-button js-menu-target" role="button" tabindex="0" aria-haspopup="true"
          data-ga-click="Repository, click Watch settings, action:blob#show">
          <span class="js-select-button">
            <span class="octicon octicon-eye"></span>
            Watch
          </span>
        </a>
        <a class="social-count js-social-count" href="/TelerikAcademy/CSharp-Part-1/watchers">
          20
        </a>

        <div class="select-menu-modal-holder">
          <div class="select-menu-modal subscription-menu-modal js-menu-content" aria-hidden="true">
            <div class="select-menu-header">
              <span class="select-menu-title">Notifications</span>
              <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
            </div>

            <div class="select-menu-list js-navigation-container" role="menu">

              <div class="select-menu-item js-navigation-item selected" role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input checked="checked" id="do_included" name="do" type="radio" value="included" />
                  <span class="select-menu-item-heading">Not watching</span>
                  <span class="description">Be notified when participating or @mentioned.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Watch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_subscribed" name="do" type="radio" value="subscribed" />
                  <span class="select-menu-item-heading">Watching</span>
                  <span class="description">Be notified of all conversations.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Unwatch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_ignore" name="do" type="radio" value="ignore" />
                  <span class="select-menu-item-heading">Ignoring</span>
                  <span class="description">Never be notified.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-mute"></span>
                    Stop ignoring
                  </span>
                </div>
              </div>

            </div>

          </div>
        </div>
      </div>
</form>
  </li>

  <li>
    
  <div class="js-toggler-container js-social-container starring-container ">

    <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/unstar" class="js-toggler-form starred js-unstar-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="Jnkzsm0rJ12aJKdaUQBUzuNHE/yTj5RFJsgzEtamj19fsaJWfQoUGrZyoPsb0h+bX/hciBFtasL2XRDWhjxaqA==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Unstar this repository" title="Unstar TelerikAcademy/CSharp-Part-1"
        data-ga-click="Repository, click unstar button, action:blob#show; text:Unstar">
        <span class="octicon octicon-star"></span>
        Unstar
      </button>
        <a class="social-count js-social-count" href="/TelerikAcademy/CSharp-Part-1/stargazers">
          12
        </a>
</form>
    <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/star" class="js-toggler-form unstarred js-star-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="9d1OvYf3rfCyfDEoS4GuHKpIadu93Xa4XfWKP/fA3wtm6QLgjLF5iBQr3IRY5ME5nl6Zn5et4br4LvrKVjldqg==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Star this repository" title="Star TelerikAcademy/CSharp-Part-1"
        data-ga-click="Repository, click star button, action:blob#show; text:Star">
        <span class="octicon octicon-star"></span>
        Star
      </button>
        <a class="social-count js-social-count" href="/TelerikAcademy/CSharp-Part-1/stargazers">
          12
        </a>
</form>  </div>

  </li>

        <li>
          <a href="#fork-destination-box" class="btn btn-sm btn-with-count"
              title="Fork your own copy of TelerikAcademy/CSharp-Part-1 to your account"
              aria-label="Fork your own copy of TelerikAcademy/CSharp-Part-1 to your account"
              rel="facebox"
              data-ga-click="Repository, show fork modal, action:blob#show; text:Fork">
            <span class="octicon octicon-repo-forked"></span>
            Fork
          </a>
          <a href="/TelerikAcademy/CSharp-Part-1/network" class="social-count">37</a>

          <div id="fork-destination-box" style="display: none;">
            <h2 class="facebox-header">Where should we fork this repository?</h2>
            <include-fragment src=""
                class="js-fork-select-fragment fork-select-fragment"
                data-url="/TelerikAcademy/CSharp-Part-1/fork?fragment=1">
              <img alt="Loading" height="64" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-128-338974454bb5c32803e82f601beb051d373744b024fe8742a76009700fd7e033.gif" width="64" />
            </include-fragment>
          </div>
        </li>

</ul>

        <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public">
          <span class="mega-octicon octicon-repo"></span>
          <span class="author"><a href="/TelerikAcademy" class="url fn" itemprop="url" rel="author"><span itemprop="title">TelerikAcademy</span></a></span><!--
       --><span class="path-divider">/</span><!--
       --><strong><a href="/TelerikAcademy/CSharp-Part-1" class="js-current-repository" data-pjax="#js-repo-pjax-container">CSharp-Part-1</a></strong>

          <span class="page-context-loader">
            <img alt="" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
          </span>

        </h1>
      </div><!-- /.container -->
    </div><!-- /.repohead -->

    <div class="container">
      <div class="repository-with-sidebar repo-container new-discussion-timeline  ">
        <div class="repository-sidebar clearfix">
            
<nav class="sunken-menu repo-nav js-repo-nav js-sidenav-container-pjax js-octicon-loaders"
     role="navigation"
     data-pjax="#js-repo-pjax-container"
     data-issue-count-url="/TelerikAcademy/CSharp-Part-1/issues/counts">
  <ul class="sunken-menu-group">
    <li class="tooltipped tooltipped-w" aria-label="Code">
      <a href="/TelerikAcademy/CSharp-Part-1" aria-label="Code" class="selected js-selected-navigation-item sunken-menu-item" data-hotkey="g c" data-selected-links="repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches /TelerikAcademy/CSharp-Part-1">
        <span class="octicon octicon-code"></span> <span class="full-word">Code</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>

      <li class="tooltipped tooltipped-w" aria-label="Issues">
        <a href="/TelerikAcademy/CSharp-Part-1/issues" aria-label="Issues" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g i" data-selected-links="repo_issues repo_labels repo_milestones /TelerikAcademy/CSharp-Part-1/issues">
          <span class="octicon octicon-issue-opened"></span> <span class="full-word">Issues</span>
          <span class="js-issue-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>      </li>

    <li class="tooltipped tooltipped-w" aria-label="Pull requests">
      <a href="/TelerikAcademy/CSharp-Part-1/pulls" aria-label="Pull requests" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g p" data-selected-links="repo_pulls /TelerikAcademy/CSharp-Part-1/pulls">
          <span class="octicon octicon-git-pull-request"></span> <span class="full-word">Pull requests</span>
          <span class="js-pull-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>

  </ul>
  <div class="sunken-menu-separator"></div>
  <ul class="sunken-menu-group">

    <li class="tooltipped tooltipped-w" aria-label="Pulse">
      <a href="/TelerikAcademy/CSharp-Part-1/pulse" aria-label="Pulse" class="js-selected-navigation-item sunken-menu-item" data-selected-links="pulse /TelerikAcademy/CSharp-Part-1/pulse">
        <span class="octicon octicon-pulse"></span> <span class="full-word">Pulse</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>

    <li class="tooltipped tooltipped-w" aria-label="Graphs">
      <a href="/TelerikAcademy/CSharp-Part-1/graphs" aria-label="Graphs" class="js-selected-navigation-item sunken-menu-item" data-selected-links="repo_graphs repo_contributors /TelerikAcademy/CSharp-Part-1/graphs">
        <span class="octicon octicon-graph"></span> <span class="full-word">Graphs</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>
  </ul>


</nav>

              <div class="only-with-full-nav">
                  
<div class="clone-url open"
  data-protocol-type="http"
  data-url="/users/set_protocol?protocol_selector=http&amp;protocol_type=clone">
  <h3><span class="text-emphasized">HTTPS</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/TelerikAcademy/CSharp-Part-1.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" data-copy-hint="Copy to clipboard" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="ssh"
  data-url="/users/set_protocol?protocol_selector=ssh&amp;protocol_type=clone">
  <h3><span class="text-emphasized">SSH</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="git@github.com:TelerikAcademy/CSharp-Part-1.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" data-copy-hint="Copy to clipboard" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="subversion"
  data-url="/users/set_protocol?protocol_selector=subversion&amp;protocol_type=clone">
  <h3><span class="text-emphasized">Subversion</span> checkout URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/TelerikAcademy/CSharp-Part-1" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" data-copy-hint="Copy to clipboard" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>



<p class="clone-options">You can clone with
  <a href="#" class="js-clone-selector" data-protocol="http">HTTPS</a>, <a href="#" class="js-clone-selector" data-protocol="ssh">SSH</a>, or <a href="#" class="js-clone-selector" data-protocol="subversion">Subversion</a>.
  <a href="https://help.github.com/articles/which-remote-url-should-i-use" class="help tooltipped tooltipped-n" aria-label="Get help on which URL is right for you.">
    <span class="octicon octicon-question"></span>
  </a>
</p>


  <a href="github-windows://openRepo/https://github.com/TelerikAcademy/CSharp-Part-1" class="btn btn-sm sidebar-button" title="Save TelerikAcademy/CSharp-Part-1 to your computer and use it in GitHub Desktop." aria-label="Save TelerikAcademy/CSharp-Part-1 to your computer and use it in GitHub Desktop.">
    <span class="octicon octicon-device-desktop"></span>
    Clone in Desktop
  </a>


                <a href="/TelerikAcademy/CSharp-Part-1/archive/master.zip"
                   class="btn btn-sm sidebar-button"
                   aria-label="Download the contents of TelerikAcademy/CSharp-Part-1 as a zip file"
                   title="Download the contents of TelerikAcademy/CSharp-Part-1 as a zip file"
                   rel="nofollow">
                  <span class="octicon octicon-cloud-download"></span>
                  Download ZIP
                </a>
              </div>
        </div><!-- /.repository-sidebar -->

        <div id="js-repo-pjax-container" class="repository-content context-loader-container" data-pjax-container>
          

<a href="/TelerikAcademy/CSharp-Part-1/blob/0014f02cd450ad30ac68c34bd467e70367a773a9/1.%20Introduction%20to%20Programming/README.md" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<!-- blob contrib key: blob_contributors:v21:9351002dc6161ca994810191e2ac1aea -->

<div class="file-navigation js-zeroclipboard-container">
  
<div class="select-menu js-menu-container js-select-menu left">
  <span class="btn btn-sm select-menu-button js-menu-target css-truncate" data-hotkey="w"
    data-master-branch="master"
    data-ref="master"
    title="master"
    role="button" aria-label="Switch branches or tags" tabindex="0" aria-haspopup="true">
    <span class="octicon octicon-git-branch"></span>
    <i>branch:</i>
    <span class="js-select-button css-truncate-target">master</span>
  </span>

  <div class="select-menu-modal-holder js-menu-content js-navigation-container" data-pjax aria-hidden="true">

    <div class="select-menu-modal">
      <div class="select-menu-header">
        <span class="select-menu-title">Switch branches/tags</span>
        <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
      </div>

      <div class="select-menu-filters">
        <div class="select-menu-text-filter">
          <input type="text" aria-label="Filter branches/tags" id="context-commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Filter branches/tags">
        </div>
        <div class="select-menu-tabs">
          <ul>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="branches" data-filter-placeholder="Filter branches/tags" class="js-select-menu-tab">Branches</a>
            </li>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="tags" data-filter-placeholder="Find a tag…" class="js-select-menu-tab">Tags</a>
            </li>
          </ul>
        </div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="branches">

        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <a class="select-menu-item js-navigation-item js-navigation-open selected"
               href="/TelerikAcademy/CSharp-Part-1/blob/master/1.%20Introduction%20to%20Programming/README.md"
               data-name="master"
               data-skip-pjax="true"
               rel="nofollow">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <span class="select-menu-item-text css-truncate-target" title="master">
                master
              </span>
            </a>
        </div>

          <div class="select-menu-no-results">Nothing to show</div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="tags">
        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


        </div>

        <div class="select-menu-no-results">Nothing to show</div>
      </div>

    </div>
  </div>
</div>

  <div class="btn-group right">
    <a href="/TelerikAcademy/CSharp-Part-1/find/master"
          class="js-show-file-finder btn btn-sm empty-icon tooltipped tooltipped-s"
          data-pjax
          data-hotkey="t"
          aria-label="Quickly jump between files">
      <span class="octicon octicon-list-unordered"></span>
    </a>
    <button aria-label="Copy file path to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" data-copy-hint="Copy file path to clipboard" type="button"><span class="octicon octicon-clippy"></span></button>
  </div>

  <div class="breadcrumb js-zeroclipboard-target">
    <span class='repo-root js-repo-root'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/TelerikAcademy/CSharp-Part-1" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">CSharp-Part-1</span></a></span></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/TelerikAcademy/CSharp-Part-1/tree/master/1.%20Introduction%20to%20Programming" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">1. Introduction to Programming</span></a></span><span class="separator">/</span><strong class="final-path">README.md</strong>
  </div>
</div>


  <div class="commit file-history-tease">
    <div class="file-history-tease-header">
        <img alt="Nikolay Kostov" class="avatar" data-user="3106986" height="24" src="https://avatars1.githubusercontent.com/u/3106986?v=3&amp;s=48" width="24" />
        <span class="author"><a href="/NikolayIT" rel="contributor">NikolayIT</a></span>
        <time datetime="2015-01-05T10:58:25Z" is="relative-time">Jan 5, 2015</time>
        <div class="commit-title">
            <a href="/TelerikAcademy/CSharp-Part-1/commit/7f2403c8318c6b9e186718441dc1e9d140a10c06" class="message" data-pjax="true" title="Update README.md">Update README.md</a>
        </div>
    </div>

    <div class="participation">
      <p class="quickstat">
        <a href="#blob_contributors_box" rel="facebox">
          <strong>2</strong>
           contributors
        </a>
      </p>
          <a class="avatar-link tooltipped tooltipped-s" aria-label="evlogihr" href="/TelerikAcademy/CSharp-Part-1/commits/master/1.%20Introduction%20to%20Programming/README.md?author=evlogihr"><img alt="evlogihr" class="avatar" data-user="3619393" height="20" src="https://avatars3.githubusercontent.com/u/3619393?v=3&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="NikolayIT" href="/TelerikAcademy/CSharp-Part-1/commits/master/1.%20Introduction%20to%20Programming/README.md?author=NikolayIT"><img alt="Nikolay Kostov" class="avatar" data-user="3106986" height="20" src="https://avatars3.githubusercontent.com/u/3106986?v=3&amp;s=40" width="20" /></a>


    </div>
    <div id="blob_contributors_box" style="display:none">
      <h2 class="facebox-header">Users who have contributed to this file</h2>
      <ul class="facebox-user-list">
          <li class="facebox-user-list-item">
            <img alt="evlogihr" data-user="3619393" height="24" src="https://avatars1.githubusercontent.com/u/3619393?v=3&amp;s=48" width="24" />
            <a href="/evlogihr">evlogihr</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Nikolay Kostov" data-user="3106986" height="24" src="https://avatars1.githubusercontent.com/u/3106986?v=3&amp;s=48" width="24" />
            <a href="/NikolayIT">NikolayIT</a>
          </li>
      </ul>
    </div>
  </div>

<div class="file">
  <div class="file-header">
    <div class="file-actions">

      <div class="btn-group">
        <a href="/TelerikAcademy/CSharp-Part-1/raw/master/1.%20Introduction%20to%20Programming/README.md" class="btn btn-sm " id="raw-url">Raw</a>
          <a href="/TelerikAcademy/CSharp-Part-1/blame/master/1.%20Introduction%20to%20Programming/README.md" class="btn btn-sm js-update-url-with-hash">Blame</a>
        <a href="/TelerikAcademy/CSharp-Part-1/commits/master/1.%20Introduction%20to%20Programming/README.md" class="btn btn-sm " rel="nofollow">History</a>
      </div>

        <a class="octicon-btn tooltipped tooltipped-nw"
           href="github-windows://openRepo/https://github.com/TelerikAcademy/CSharp-Part-1?branch=master&amp;filepath=1.%20Introduction%20to%20Programming%2FREADME.md"
           aria-label="Open this file in GitHub for Windows">
            <span class="octicon octicon-device-desktop"></span>
        </a>

            <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/edit/master/1.%20Introduction%20to%20Programming/README.md" class="inline-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="33ou6TCYaxUv8Ut8PUfv4OW+Ih8hFJvFMQb8jRpBslh0mZl81ecbhjgPnDETLNeM1dySj3a2Fi4dBmI1wlGR6g==" /></div>
              <button class="octicon-btn tooltipped tooltipped-n" type="submit" aria-label="Clicking this button will fork this project so you can edit the file" data-hotkey="e" data-disable-with>
                <span class="octicon octicon-pencil"></span>
              </button>
</form>
          <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/delete/master/1.%20Introduction%20to%20Programming/README.md" class="inline-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="/y3xefDpoe/dMQk1G7qGvi+acH62vob6gaRSsKsjG0C2e4rR0h871ZscSlKkdn8jJXaEZqQ+5T1/zcs8BYyhzg==" /></div>
            <button class="octicon-btn octicon-btn-danger tooltipped tooltipped-n" type="submit" aria-label="Fork this project and delete file" data-disable-with>
              <span class="octicon octicon-trashcan"></span>
            </button>
</form>    </div>

    <div class="file-info">
        115 lines (83 sloc)
        <span class="file-info-divider"></span>
      5.082 kb
    </div>
  </div>
    <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1>
<a id="user-content-homework-introduction-to-programming" class="anchor" href="#homework-introduction-to-programming" aria-hidden="true"><span class="octicon octicon-link"></span></a>Homework: Introduction to Programming</h1>

<h3>
<a id="user-content-problem-1--play-with-visual-studio" class="anchor" href="#problem-1--play-with-visual-studio" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 1.  Play with Visual Studio</h3>

<ul class="task-list">
<li>  Install Visual Studio on your laptop or home computer. Go to the official <a href="http://www.visualstudio.com/en-us/downloads/download-visual-studio-vs.aspx">Visual Studio</a> site and download the <strong>Community 2013 with Update 4</strong> version.</li>
<li>  Start Visual Studio and familiarize yourself with it. Create a simple C# program (console application), compile and run it.</li>
</ul>

<p>You do not have to submit anything in your homework for this problem.</p>

<h3>
<a id="user-content-problem-2--blank-solution-in-visual-studio" class="anchor" href="#problem-2--blank-solution-in-visual-studio" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 2.  Blank Solution in Visual Studio</h3>

<ul class="task-list">
<li>
<p>Create a blank solution in Visual Studio called <code>“Intro-Programming-Homework”</code>. This solution will hold all your homework projects, code and files. For each problem (exercises) add a separate project with self-descriptive name like <code>“Hello-World”</code> and <code>“Print-Your-Name”</code>.</p>

<p>You do not have to submit anything in your homework for this problem.</p>
</li>
</ul>

<h3>
<a id="user-content-problem-3--play-with-msdn-library" class="anchor" href="#problem-3--play-with-msdn-library" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 3.  Play with MSDN Library</h3>

<ul class="task-list">
<li>  Play with <a href="http://msdn.microsoft.com/library">Microsoft Developer Network (MSDN)</a>  Library Documentation.

<ul class="task-list">
<li>  Find information about Console.WriteLine() method in MSDN.</li>
<li>  Find information about the Console class.</li>
<li>  Find information about the class keyword.</li>
</ul>
</li>
</ul>

<p>You do not have to submit anything in your homework for this problem.</p>

<h3>
<a id="user-content-problem-4--hello-world" class="anchor" href="#problem-4--hello-world" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 4.  Hello World</h3>

<ul class="task-list">
<li>  Create, compile and run a <code>“Hello C#”</code> console application.</li>
<li>  Ensure you have named the application well (e.g. “”HelloCSharp”).</li>
</ul>

<p>You should submit the Visual Studio project holding the HelloCSharp class as part of your homework.</p>

<h3>
<a id="user-content-problem-5--print-your-name" class="anchor" href="#problem-5--print-your-name" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 5.  Print Your Name</h3>

<ul class="task-list">
<li>  Modify the previous application to print your name.</li>
<li>  Ensure you have named the application well (e.g. “PrintMyName”).</li>
</ul>

<p>You should submit a separate project Visual Studio project holding the PrintMyName class as part of your homework.</p>

<h3>
<a id="user-content-problem-6--print-numbers" class="anchor" href="#problem-6--print-numbers" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 6.  Print Numbers</h3>

<ul class="task-list">
<li>  Write a program to print the numbers <code>1, 101 and 1001</code>, each at a separate line.</li>
<li>  Name the program correctly.</li>
</ul>

<p>You should submit in your homework the Visual Studio project holding the source code of the PrintNumbers program.</p>

<h3>
<a id="user-content-problem-7--print-first-and-last-name" class="anchor" href="#problem-7--print-first-and-last-name" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 7.  Print First and Last Name</h3>

<ul class="task-list">
<li>  Create console application that prints your first and last name, each at a separate line.</li>
</ul>

<h3>
<a id="user-content-problem-8--square-root" class="anchor" href="#problem-8--square-root" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 8.  Square Root</h3>

<ul class="task-list">
<li>  Create a console application that calculates and prints the square root of the number <code>12345</code>.</li>
<li>  Find in Internet “how to calculate square root in C#”.</li>
</ul>

<h3>
<a id="user-content-problem-9--print-a-sequence" class="anchor" href="#problem-9--print-a-sequence" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 9.  Print a Sequence</h3>

<ul class="task-list">
<li>  Write a program that prints the first 10 members of the sequence: <code>2, -3, 4, -5, 6, -7, ...</code>
</li>
</ul>

<h3>
<a id="user-content-problem-10-reformat-c-code" class="anchor" href="#problem-10-reformat-c-code" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 10. Reformat C# Code</h3>

<ul class="task-list">
<li>  Reformat the following C# code to make it readable according to the C# best practices for code formatting. Change the casing of the identifiers in the code (e.g. use PascalCase for the class name):
HorribleCode.cs</li>
</ul>

<div class="highlight highlight-c#"><pre><span class="pl-k">using</span>

System;

<span class="pl-k">class</span> <span class="pl-en">hoRRiblEcoDe</span>
{
    <span class="pl-k">static</span>
     <span class="pl-k">void</span>

        <span class="pl-en">Main</span>()
    {
        Console.

    WriteLine(<span class="pl-s"><span class="pl-pds">"</span>Hi, I am horribly formatted program<span class="pl-pds">"</span></span>
); Console.
      WriteLine(<span class="pl-s"><span class="pl-pds">"</span>Numbers and squares:<span class="pl-pds">"</span></span>)
; <span class="pl-k">for</span> (<span class="pl-k">int</span> i = <span class="pl-c1">0</span>;
i &lt; <span class="pl-c1">10</span>;
i++)
        {
            Console.WriteLine(i +
                <span class="pl-s"><span class="pl-pds">"</span> --&gt; <span class="pl-pds">"</span></span> + i
                *
                i);
        }
    }
}</pre></div>

<h3>
<a id="user-content-problem-11-programming-languages" class="anchor" href="#problem-11-programming-languages" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 11. Programming Languages</h3>

<ul class="task-list">
<li>  Perform a research (e.g. in Google or Wikipedia) and provide a short list with information about the most popular programming languages. How similar are they to C#? How do they differ from C#?</li>
<li>  Write in a text file called <code>“programming-languages.txt”</code> at least five languages along with 2-3 sentences about each of them. Use English.</li>
</ul>

<h3>
<a id="user-content-problem-12-development-environments" class="anchor" href="#problem-12-development-environments" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 12. Development Environments</h3>

<ul class="task-list">
<li>  Perform a research (e.g. in Google or Wikipedia) and provide a short list with popular development environments (IDEs) like Visual Studio.</li>
<li>  Write in a text file called <code>“list-of-IDEs.txt”</code> at least five IDEs along with 2-3 sentences about each of them. Use English.</li>
</ul>

<h3>
<a id="user-content-problem-13-c-and-net-differences" class="anchor" href="#problem-13-c-and-net-differences" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 13. C# and .NET Differences</h3>

<ul class="task-list">
<li>  Describe the difference between C# and .NET Framework in 2-3 sentences.</li>
<li>  Write your description in a text file called <code>“csharp-and-dot-net-framework.txt”</code>. Use English.</li>
</ul>

<h3>
<a id="user-content-problem-14----current-date-and-time" class="anchor" href="#problem-14----current-date-and-time" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 14.*    Current Date and Time</h3>

<ul class="task-list">
<li>  Create a console application that prints the current date and time. Find out how in Internet.</li>
</ul>

<h3>
<a id="user-content-problem-15----age-after-10-years" class="anchor" href="#problem-15----age-after-10-years" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 15.*    Age after 10 Years</h3>

<ul class="task-list">
<li>  Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.</li>
</ul>

<h3>
<a id="user-content-problem-16----print-long-sequence" class="anchor" href="#problem-16----print-long-sequence" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 16.*    Print Long Sequence</h3>

<ul class="task-list">
<li>  Write a program that prints the first 1000 members of the sequence: <code>2, -3, 4, -5, 6, -7, …</code>
</li>
<li>  You might need to learn how to use loops in C# (search in Internet).</li>
</ul>

<h3>
<a id="user-content-problem-17----play-with-the-debugger-in-visual-studio" class="anchor" href="#problem-17----play-with-the-debugger-in-visual-studio" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 17.*    Play with the Debugger in Visual Studio</h3>

<ul class="task-list">
<li>  Write a program that prints at the console the numbers from <code>1 to 1000</code>, each at a separate line.</li>
<li>  You might need to learn how to use loops (search in Internet).</li>
<li>  Set a breakpoint in the line, which prints the next number in the Visual Studio code editor. Run the program through the debugger using the <code>[F5]</code> key. When the debugger stops at the breakpoint trace the code execution with <code>[F10]</code> key.</li>
</ul>

<p>You do not have to submit anything in your homework for this problem. Just play with the debugger to learn how it works.</p>
</article>
  </div>

</div>

<a href="#jump-to-line" rel="facebox[.linejump]" data-hotkey="l" style="display:none">Jump to Line</a>
<div id="jump-to-line" style="display:none">
  <form accept-charset="UTF-8" action="" class="js-jump-to-line-form" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
    <input class="linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" autofocus>
    <button type="submit" class="btn">Go</button>
</form></div>

        </div>

      </div><!-- /.repo-container -->
      <div class="modal-backdrop"></div>
    </div><!-- /.container -->
  </div><!-- /.site -->


    </div><!-- /.wrapper -->

      <div class="container">
  <div class="site-footer" role="contentinfo">
    <ul class="site-footer-links right">
        <li><a href="https://status.github.com/" data-ga-click="Footer, go to status, text:status">Status</a></li>
      <li><a href="https://developer.github.com" data-ga-click="Footer, go to api, text:api">API</a></li>
      <li><a href="https://training.github.com" data-ga-click="Footer, go to training, text:training">Training</a></li>
      <li><a href="https://shop.github.com" data-ga-click="Footer, go to shop, text:shop">Shop</a></li>
        <li><a href="https://github.com/blog" data-ga-click="Footer, go to blog, text:blog">Blog</a></li>
        <li><a href="https://github.com/about" data-ga-click="Footer, go to about, text:about">About</a></li>

    </ul>

    <a href="https://github.com" aria-label="Homepage">
      <span class="mega-octicon octicon-mark-github" title="GitHub"></span>
</a>
    <ul class="site-footer-links">
      <li>&copy; 2015 <span title="0.08142s from github-fe126-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
        <li><a href="https://github.com/site/terms" data-ga-click="Footer, go to terms, text:terms">Terms</a></li>
        <li><a href="https://github.com/site/privacy" data-ga-click="Footer, go to privacy, text:privacy">Privacy</a></li>
        <li><a href="https://github.com/security" data-ga-click="Footer, go to security, text:security">Security</a></li>
        <li><a href="https://github.com/contact" data-ga-click="Footer, go to contact, text:contact">Contact</a></li>
    </ul>
  </div>
</div>


    <div class="fullscreen-overlay js-fullscreen-overlay" id="fullscreen_overlay">
  <div class="fullscreen-container js-suggester-container">
    <div class="textarea-wrap">
      <textarea name="fullscreen-contents" id="fullscreen-contents" class="fullscreen-contents js-fullscreen-contents" placeholder=""></textarea>
      <div class="suggester-container">
        <div class="suggester fullscreen-suggester js-suggester js-navigation-container"></div>
      </div>
    </div>
  </div>
  <div class="fullscreen-sidebar">
    <a href="#" class="exit-fullscreen js-exit-fullscreen tooltipped tooltipped-w" aria-label="Exit Zen Mode">
      <span class="mega-octicon octicon-screen-normal"></span>
    </a>
    <a href="#" class="theme-switcher js-theme-switcher tooltipped tooltipped-w"
      aria-label="Switch themes">
      <span class="octicon octicon-color-mode"></span>
    </a>
  </div>
</div>



    
    

    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      <a href="#" class="octicon octicon-x flash-close js-ajax-error-dismiss" aria-label="Dismiss error"></a>
      Something went wrong with that request. Please try again.
    </div>


      <script crossorigin="anonymous" src="https://assets-cdn.github.com/assets/frameworks-2c8ae50712a47d2b83d740cb875d55cdbbb3fdbccf303951cc6b7e63731e0c38.js"></script>
      <script async="async" crossorigin="anonymous" src="https://assets-cdn.github.com/assets/github-a8298930bc879205b7c77472e37c8bbc58da94d4b7c970cd899dfe0b65289591.js"></script>
      
      

  </body>
</html>

