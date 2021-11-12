import SocialNetworks from "./SocialNetworks";
import CategoriesDropdown from "./CategoriesDropdown";
import TopicsDropdown from "./TopicsDropdown";
import ArticlesDropdown from "./ArticlesDropdown";
import React from 'react';
import { useState, useEffect } from 'react';


const categoriesUrl = "https://localhost:44319/categories";

const topicsUrl = "https://localhost:44319/topics";

const articlesUrl = "https://localhost:44319/articles";

function Header() {

    const [categories, setCategories] = useState([]);

    const [topics, setTopics] = useState([]);

    const [articles, setArticles] = useState([]);

    useEffect(() => {
        fetch(categoriesUrl)
            .then(result => result.json())
            .then(resultCategories => {
                setCategories(Object.values(resultCategories))
            });
    }, []);

    useEffect(() => {
        fetch(topicsUrl)
            .then(result => result.json())
            .then(topics => {
                setTopics(Object.values(topics))
            });
    }, []);

    useEffect(() => {
        fetch(articlesUrl)
            .then(result => result.json())
            .then(articles => {
                setArticles(Object.values(articles))
            });
    }, []);

    return (
        <header>
            <div className="top">
                <div className="container">
                    <div className="row">
                        <div className="span6">
                            <ul className="topmenu">
                                <li><a href="#">Home</a> &#47;</li>
                                <li><a href="#">Terms</a> &#47;</li>
                                <li><a href="#">Privacy policy</a></li>
                            </ul>
                        </div>
                        <SocialNetworks />
                    </div>
                </div>
            </div>
            <div className="container">


                <div className="row nomargin">
                    <div className="span4">
                        <div className="logo">
                            <h1><a href="index.html"><i className="icon-tint"></i> AI Today</a></h1>
                        </div>
                    </div>
                    <div className="span8">
                        <div className="navbar navbar-static-top">
                            <div className="navigation">
                                <nav>
                                    <ul className="nav topnav">
                                        <li className="active">
                                            <a href="index.html">Home</a>
                                        </li>
                                        <li class="dropdown">
                                            <a href="categories">Categories <i class="icon-angle-down"></i></a>
                                            <ul class="dropdown-menu">
                                                {categories.map(c => <CategoriesDropdown key={c.id} name={ c.name }/>) }
                                            </ul>
                                        </li>
                                        <li class="dropdown">
                                            <a href="#">Topics <i class="icon-angle-down"></i></a>
                                            <ul class="dropdown-menu">
                                                {topics.map(t => <TopicsDropdown key={t.id} name={ t.name }/>) }
                                            </ul>
                                        </li>
                                        <li class="dropdown">
                                            <a href="#">Articles <i class="icon-angle-down"></i></a>
                                            <ul class="dropdown-menu">
                                                {articles.map(a => <ArticlesDropdown key={a.id} heading={ a.heading }/>) }
                                            </ul>
                                        </li>
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