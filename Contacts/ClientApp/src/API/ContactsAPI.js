const api = "/spi/ContactController";

export const getAll = () =>
    fetch(`${api}/GetAll`)
        .then(res => res.json())
        .then(data => data.contactList)

export const get = (contactID) =>
    fetch(`${api}/Get/${contactID}`)
        .then(res => res.json())
        .then(data => data.contact)

export const add = (contact) =>
    fetch(`${api}/Add`, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ contact })
    }).then(res => res.json())
        .then(data => data.contactList)

export const update = (contactID, newContact) =>
    fetch(`${api}/Get/${contactID}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ newContact })
    }).then(res => res.json())

export const del = (contactID) =>
    fetch(`${api}/Delete`, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ contactID })
    }).then(res => res.json())
        .then(data => data.contactList)