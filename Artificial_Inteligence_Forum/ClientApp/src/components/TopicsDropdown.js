import React from 'react';

function TopicsDropdown() {
    return (
        <li class="dropdown">
            <a href="#">Topics <i class="icon-angle-down"></i></a>
            <ul class="dropdown-menu">
                <li><a href="about.html">About us</a></li>
                <li><a href="pricingbox.html">Pricing boxes</a></li>
                <li><a href="404.html">404</a></li>
            </ul>
        </li>
    )
}

export default TopicsDropdown;