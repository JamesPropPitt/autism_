#include <iostream>
#include <SDL.h>

const int WIDTH = 1920, HEIGHT = 1080;

using namespace std;
int main(int argc, char *argv[]) 
{
	SDL_Surface *imageSurface = NULL;
	//Create imageSurface
	SDL_Surface *windowSurface = NULL;
	//Create windowSurface

	if (SDL_Init(SDL_INIT_EVERYTHING) < 0)
	{
		std::cout << "SDL could not initialise! SDL Error: " << SDL_GetError() << endl;
		//Error catching
	}
	SDL_Window *window = SDL_CreateWindow("Autimulation", SDL_WINDOWPOS_UNDEFINED,
		SDL_WINDOWPOS_UNDEFINED, WIDTH, HEIGHT, SDL_WINDOW_ALLOW_HIGHDPI);
		//Create the window of 1920 by 1080 pixels

	windowSurface = SDL_GetWindowSurface(window);
	//Assign the window to windowSurface(sounds kinda dumb when explaining it)
	if (NULL == window)
	{
		std::cout << "Could not create window: " << SDL_GetError() << endl;
		return EXIT_FAILURE;
		//Error catching
	}
	SDL_Event windowEvent;
	//Create event called windowEvent

	imageSurface = SDL_LoadBMP("1.bmp");
	//Assign An image to imageSurface
	SDL_Rect frameR;
	frameR.x = 100;
	frameR.y = 300;

	if (NULL == imageSurface)
	{
		std::cout << "SDL could not load image: SDL Error:" << SDL_GetError() << endl;
	}
	while (true)
	{
		if (SDL_PollEvent(&windowEvent))
		{
			if (SDL_QUIT == windowEvent.type)
			{
				break;
				//Close the program
			}
		}
		SDL_BlitSurface(imageSurface, NULL, windowSurface, &frameR);
		//Blit the image onto the screen
		SDL_UpdateWindowSurface(window);
		//Update screen with image
	}
	SDL_FreeSurface(imageSurface);
	//Clean the imageSurface
	SDL_FreeSurface(windowSurface);
	//Clean the windowSurface
	imageSurface = NULL;
	windowSurface = NULL;

	SDL_DestroyWindow(window);
	SDL_Quit();
	return EXIT_SUCCESS;
}