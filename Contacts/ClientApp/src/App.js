import React, { Component } from 'react';
import * as ContactsAPI from './API/ContactsAPI'
import ContactsList from './components/ContactsList'

const contacts = [
    {
        "id": "ryan",
        "name": "Ryan Florence",
        "email": "ryan@reacttraining.com",
        "avatarURL": "/ryan.jpg"
    },
    {
        "id": "michael",
        "name": "Michael Jackson",
        "email": "michael@reacttraining.com",
        "avatarURL": "/michael.jpg"
    },
    {
        "id": "tyler",
        "name": "Tyler McGinnis",
        "email": "tyler@reacttraining.com",
        "avatarURL": "/tyler.jpg"
    }
]

class App extends Component {
    render() {
        return <ContactsList contacts={contacts} />
    }
}
export default App;

