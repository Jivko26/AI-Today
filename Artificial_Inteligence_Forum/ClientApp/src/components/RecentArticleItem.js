import React from 'react';

function RecentArticleItem({ image, heading }) {
    return (
        <div className="span3">
            <div className="item">
                <figure>
                    <div><img src={ image } alt="" /></div>
                    <figcaption>
                        <h3>{ heading }</h3>
                    </figcaption>
                </figure>
            </div>
        </div>
    );
}

export default RecentArticleItem;
