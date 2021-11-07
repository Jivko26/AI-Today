import React from 'react';

function CategoriesDropdown() {
    return (
        <li class="dropdown">
            <a href="#">Categories <i class="icon-angle-down"></i></a>
            <ul class="dropdown-menu">
                <li><a href="typography.html">Typography</a></li>
                <li><a href="components.html">Components</a></li>
                <li><a href="icons.html">Icons</a></li>
                <li><a href="icon-variations.html">Icon variations</a></li>

            </ul>
        </li>
    )
}

export default CategoriesDropdown;