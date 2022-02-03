import logo from './1200px-International_Pokémon_logo.svg.png';
import './App.css';



function App(){
  function SentData() {        
    var pokemonName = document.getElementById("PokemonSearchNameId").value;
    if (pokemonName == "") {
        alert("Please, insert a pokemon name");
        return;
    }

           

  fetch("https://localhost:5001/api/pokemon?pokemonName="+pokemonName)
  .then(res => res.json())
    .then(function(response)
    {
      onGetDescritption(response);
    } )
    .catch(function(errore){
      OnGetDescriptionFailed(errore);
    });

    //PageMethods.GetDescription(pokemonName, OnGetDescritption, OnGetDescriptionFailed)
  }

  // handle the success result.
  function onGetDescritption(response) {
      if (response) {

          document.getElementById("PokemonNameId").value = response.pokemonName;
          document.getElementById("PokemonDescriptionId").value = response.descritpion;
          document.getElementById("PokemonDescriptionShaspeareId").value = response.descritpionShakespeare;
         
          document.getElementById("SearchForm").style.display = "none";
          document.getElementById("ResultForm").style.display = "block";
      
      }
  }

  // handle the error from server.
  function OnGetDescriptionFailed(errore) {
      alert("An error has been occured!");
  }


  // return back to the search bar.
  function  Back() {
    document.getElementById("SearchForm").style.display = "";
    document.getElementById("ResultForm").style.display = "none";
  }
  return(
    <div>
            <div className="container">
                <div className="row">
                    <div className="col-12">
                        <img src = {logo} className="img-responsive" />
                    </div>
                </div>
            </div>
            <br />
            <div className="container">
                <div className="row">
                    <div className="col-9">
                        <div className="form-group" id="SearchForm">
                            <div className="input-group">
                                <input type="text" id="PokemonSearchNameId" className="form-control" />
                                <button type="button" className="btn btn-default"  onClick={SentData}>
                                    Search
                                </button>
                            </div>
                        </div>
                        <div className="form-group" id="ResultForm" >
                            <div className="col-md-12">
                                <div className="input-group">
                                    <label className="col-2">
                                        Pokemon Name:
                                    </label>

                                    <input type="text" id="PokemonNameId" className="form-control" />

                                </div>
                                <br />

                                <div className="input-group">
                                    <label className="col-2">
                                        Description:
                                    </label>
                                    <input type="text" id="PokemonDescriptionId" className="form-control" />
                                </div>
                                <br />
                                <div className="input-group">
                                    <label className="col-3">
                                        Description Shakespeare 
                                <br />
                                        (if equal to the description it means does not exist the translation):
                                    </label>
                                    <input type="text" id="PokemonDescriptionShaspeareId" className="form-control" />
                                </div>
                                <br />
                                <div className="input-group">
                                    <button type="button" className="btn btn-default"  onClick={Back}>
                                        Back
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
  )
}

export default App;
