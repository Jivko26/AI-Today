import React, { useState, useEffect } from 'react';
import RecentArticleItem from "./RecentArticleItem";

const articlesUrl = "https://localhost:44319/articles/recentArticles";

function RecentArticles() {

    const [articles, setArticles] = useState([]);

    useEffect(() => {
        fetch(articlesUrl)
            .then(result => result.json())
            .then(articles => {
                setArticles(Object.values(articles))
            });
    }, []);

    return (
        <section id="works">
            <div className="container">
                <div class="row">
                    <div className="span12">
                        <h3>Recent articles</h3>
                        <div className="row">

                            <div className="grid cs-style-3">
                                {articles.map(a => <RecentArticleItem key={a.id} image={a.image} heading={ a.heading }/>) }
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </section>

    );
}

export default RecentArticles;