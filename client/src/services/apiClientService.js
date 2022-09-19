export class ApiClientService {
  async get(url) {
    const configInitGet = {
      method: 'GET'
    }
    const response = await fetch(url, configInitGet);

    return response;
  }

  async post(url, datatab) {
    const configInitPost = {
      method: 'POST',
      body: JSON.stringify(datatab),
      headers: {
        'Content-Type': 'application/json',
      }
    };
    const response = await fetch(url, configInitPost);

    return response;
  }

  async put(url, datatab) {
    const configInitPut = {
      method: 'PUT',
      body: JSON.stringify(datatab),
      headers: {
        'Content-Type': 'application/json',
      }
    };
    const response = await fetch(url, configInitPut);

    return response;
  }

  async delete(url) {
    const configInitDelete = {
      method: 'DELETE'
    }
    const response = await fetch(url, configInitDelete);

    return response;
  }
}
