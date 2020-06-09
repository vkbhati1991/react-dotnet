import React from "react";
import { NavLink } from 'react-router-dom';

function AppHeader() {
    return (
        <div className="app-header flex items-center bb b--light-gray bg-white">
            <div className="app-logo">
                <img alt="" src="assets/images/vlogo1.svg" />
            </div>
            <div className="app-search flex-1"></div>
            <div className="app-notification relative mh-16">
                <span className="notif-icon primary f24 pointer db">
                    <i className="fa fa-bell-o"></i>
                </span>
            </div>
            <div className="app-profile relative flex items-center">
                <div className="app-profile-image ht32 wt32 min-wt32 overflow-hidden br-pill">
                    <img alt="" src="assets/images/businessman.png" />
                    <div className="app-profile-user ttc f14 dn">admin</div>
                </div>
                <div className="app-logout mh-16">
                    <NavLink className="logout-icon f24 pointer red db" to="/Logout"> <i className="fa fa-sign-out"></i></NavLink>
                </div>
            </div>
        </div>
    );
}

export { AppHeader };