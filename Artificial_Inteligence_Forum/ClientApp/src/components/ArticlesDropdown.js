import React from 'react';

function ArticlesDropdown() {
    return (
        <li class="dropdown">
            <a href="#">Articles <i class="icon-angle-down"></i></a>
            <ul class="dropdown-menu">
                <li><a href="portfolio-2cols.html">Portfolio 2 columns</a></li>
                <li><a href="portfolio-3cols.html">Portfolio 3 columns</a></li>
                <li><a href="portfolio-4cols.html">Portfolio 4 columns</a></li>
                <li><a href="portfolio-detail.html">Portfolio detail</a></li>
            </ul>
        </li>
    )
}

export default ArticlesDropdown;