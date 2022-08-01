import React, {useState} from 'react';

export const CovidCertificate = () => {
  const [name, setName] = useState('')
  const [surname, setSurname] = useState('')
  const [date, setDate] = useState('')

  const changeNameHandler = (event) => {
    setName(event.target.value)
  }
  const changeSurnameHandler = (event) => {
    setSurname(event.target.value)
  }
  const changeDateHandler = (event) => {
    setDate(event.target.value)
  }

  return (
      <form>
        <h4>Бланк додавання сертифіката ковід</h4>
        <div className="input-field mt2">
          <input
              onChange={changeNameHandler}
              value={name}
              type="text"
              id="name"
              placeholder="Введіть ім'я пацієнта"
          />
          <label htmlFor="name" className="active">Введіть ім'я пацієнта:</label>
        </div>
        <div className="input-field">
          <input
              onChange={changeSurnameHandler}
              value={surname}
              type="text"
              id="surname"
              placeholder="Введіть фамілію пацієнта"
          />
          <label htmlFor="surname" className="active">Введіть фамілію пацієнта:</label>
        </div>
        <div className="input-field">
          <input
              onChange={changeDateHandler}
              value={date}
              type="date"
              id="date"
          />
          <label htmlFor="date" className="active">Введіть дату народження:</label>
        </div>
          <h5>Відскануйте qr-код</h5>

          <div className="row">
              <div className="col">
                  <div id="reader"></div>
              </div>
              <div className="col">
                  <h4>SCAN RESULT</h4>
                  <div id="result">Result Here</div>
              </div>
          </div>

          <button className="btn waves-effect waves-light" type="submit" name="action">Відправити
          <i className="material-icons right">send</i>
        </button>
      </form>
    )

}
