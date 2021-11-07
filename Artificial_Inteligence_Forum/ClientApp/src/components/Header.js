import SocialNetworks from "./SocialNetworks";
import CategoriesDropdown from "./CategoriesDropdown";
import TopicsDropdown from "./TopicsDropdown";
import ArticlesDropdown from "./ArticlesDropdown";
import React from 'react';

function Header() {

    return (
        <header>
            <div class="top">
                <div class="container">
                    <div class="row">
                        <div class="span6">
                            <ul class="topmenu">
                                <li><a href="#">Home</a> &#47;</li>
                                <li><a href="#">Terms</a> &#47;</li>
                                <li><a href="#">Privacy policy</a></li>
                            </ul>
                        </div>
                        <SocialNetworks />
                    </div>
                </div>
            </div>
            <div class="container">


                <div class="row nomargin">
                    <div class="span4">
                        <div class="logo">
                            <h1><a href="index.html"><i class="icon-tint"></i> AI Today</a></h1>
                        </div>
                    </div>
                    <div class="span8">
                        <div class="navbar navbar-static-top">
                            <div class="navigation">
                                <nav>
                                    <ul class="nav topnav">
                                        <li class="active">
                                            <a href="index.html">Home</a>
                                        </li>
                                        <CategoriesDropdown />
                                        <TopicsDropdown />
                                        <ArticlesDropdown />
                                    </ul>
                                </nav>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </header>
    );
}

export default Header;