import { insideNutriTemplatePage } from './app.po';

describe('insideNutri App', function() {
  let page: insideNutriTemplatePage;

  beforeEach(() => {
    page = new insideNutriTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
