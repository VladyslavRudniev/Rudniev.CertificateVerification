import React, { Component } from 'react';
import { Navbar } from "./Components/Navbar";
import { CovidCertificate } from "./Components/CovidCertificate";

export default class App extends Component {
    static displayName = App.name;

    constructor(props) {
        super(props);
        this.state = { };
    }

    render() {
        return (
            <>
                <Navbar />
                <CovidCertificate />
            </>
        );
    }
}
