import {
  GET_ALL_TASKS,
  ADD_TASK,
  PUT_TASK,
  DELETE_TASK
} from '../constants/task/actionTypes';

const defaultState = {
  tasks: []
}

export const taskReducer = (state = defaultState, action) => {
  switch (action.type) {
    case GET_ALL_TASKS:
      return { ...state, };

    case ADD_TASK:
      return { ...state, };

    case PUT_TASK:
      return { ...state, };

    case DELETE_TASK:
      return { ...state, };

    default: return state;
  }
}