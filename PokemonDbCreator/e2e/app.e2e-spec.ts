import { PokemonDbCreatorPage } from './app.po';

describe('pokemon-db-creator App', function() {
  let page: PokemonDbCreatorPage;

  beforeEach(() => {
    page = new PokemonDbCreatorPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
